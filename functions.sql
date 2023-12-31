CREATE OR REPLACE FUNCTION check_password() RETURNS trigger AS $$
BEGIN
    IF (length(new.password) < 8) THEN
        RAISE EXCEPTION 'Пароль должен содержать минимум 8 символов';
    END IF;

    IF (new.password !~ '[A-Za-z0-9]') THEN
        RAISE EXCEPTION 'Пароль должен содержать буквы и цифры';
    END IF;

    RETURN new;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER check_password
    BEFORE INSERT OR UPDATE ON UserCredentials
    FOR EACH ROW
EXECUTE PROCEDURE check_password();

CREATE OR REPLACE FUNCTION check_unique_login() RETURNS trigger AS $$
BEGIN
    IF (EXISTS (SELECT 1 FROM UserCredentials WHERE Login = NEW.Login)) THEN
        RAISE EXCEPTION 'Логин должен быть уникальным';
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER check_unique_login
    BEFORE INSERT OR UPDATE ON UserCredentials
    FOR EACH ROW
EXECUTE PROCEDURE check_unique_login();

CREATE OR REPLACE FUNCTION check_position_count() RETURNS trigger AS $$
DECLARE
    position_count INTEGER;
    employees_count INTEGER;
BEGIN
    IF (NEW.PositionId IS NOT NULL) THEN

        SELECT Count INTO position_count
        FROM Positions
        WHERE Id = NEW.PositionId;

        SELECT count(*) INTO employees_count
        FROM Employees
        WHERE PositionId = NEW.PositionId;

        IF (employees_count >= position_count) THEN
            RAISE EXCEPTION 'Превышено максимальное количество сотрудников на позиции %', NEW.PositionId;
        END IF;

    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER check_position_count
    BEFORE INSERT ON Employees
    FOR EACH ROW
EXECUTE PROCEDURE check_position_count();

-- функция на удаление аттракционов, чтобы удалялись данные из таблицы билетов
CREATE OR REPLACE FUNCTION delete_tickets_on_attraction_delete()
    RETURNS TRIGGER AS $$
BEGIN
    DELETE FROM TicketAttractions WHERE AttractionID = OLD.id;

    RETURN OLD;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER trg_delete_tickets_on_attraction_delete
    BEFORE DELETE ON Attractions
    FOR EACH ROW
EXECUTE FUNCTION delete_tickets_on_attraction_delete();

-- Установка PositionID в NULL для сотрудников с удаляемой позицией
CREATE OR REPLACE FUNCTION delete_position_trigger()
    RETURNS TRIGGER AS $$
BEGIN
    UPDATE Employees SET PositionID = NULL WHERE PositionID = OLD.Id;

    IF NOT TG_OP = 'DELETE' THEN
        DELETE FROM Positions WHERE Id = OLD.Id;
    END IF;

    RETURN OLD;
END;
$$ LANGUAGE plpgsql;


CREATE OR REPLACE TRIGGER trg_delete_position
    BEFORE DELETE ON Positions
    FOR EACH ROW
EXECUTE FUNCTION delete_position_trigger();

CREATE OR REPLACE FUNCTION delete_employee_cascade()
    RETURNS TRIGGER AS $$
BEGIN
    DELETE FROM Tickets
    WHERE EmployeeId = OLD.Id;

    DELETE FROM Employees
    WHERE Id = OLD.Id;

    RETURN OLD;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_delete_employee_cascade
    BEFORE DELETE ON UserCredentials
    FOR EACH ROW
EXECUTE FUNCTION delete_employee_cascade();

-- удаление из таблицы Tickets
CREATE OR REPLACE FUNCTION delete_ticket_attractions()
    RETURNS TRIGGER AS $$
BEGIN
    DELETE FROM TicketAttractions WHERE TicketId = OLD.Id;
    RETURN OLD;
END;
$$ LANGUAGE plpgsql;

CREATE OR REPLACE TRIGGER trigger_delete_ticket_attractions
    AFTER DELETE ON Tickets
    FOR EACH ROW
EXECUTE FUNCTION delete_ticket_attractions();

ALTER TABLE TicketAttractions
    DROP CONSTRAINT IF EXISTS ticketattractions_ticketid_fkey;

ALTER TABLE TicketAttractions
    ADD CONSTRAINT ticketattractions_ticketid_fkey
        FOREIGN KEY (TicketId) REFERENCES Tickets(Id) ON DELETE CASCADE;