INSERT INTO UserCredentials (Login, Password)
VALUES
    ('sbsb', 'awdawd11'),
    ('petrov', 'awdawd123'),
    ('sidorov', '123qwerty'),
    ('ivanov', '123abcabc'),
    ('sidorova', 'qwerty123'),
    ('admin', 'admin123');

SELECT COUNT(*) FROM UserCredentials WHERE Login = 'sbsb' AND Password = 'awdawd11';

INSERT INTO Positions (Position, Salary, Count)
VALUES
    ('Директор', 90000, 1),
    ('Администратор', 70000, 2),
    ('Менеджер', 60000, 3),
    ('Кассир', 45000, 6),
    ('Стажер', 25000, 6);

INSERT INTO Employees (UserCredentialId, FirstName, LastName, MiddleName, DateOfBirth, PositionId)
VALUES
    (1, 'Сабина', 'Калкаманова', 'Марселевна', '2003-03-14', 1),
    (2, 'Петр', 'Петров', 'Петрович', '1985-03-15', 2),
    (3, 'Игорь', 'Сидоров', 'Игоревич', '1990-05-05', 3),
    (4, 'Иван', 'Иванов', 'Иванович', '1980-01-20', 4),
    (5, 'Мария','Сидорова','Петровна','1995-05-12', 3),
    (6, 'Петр','Петров','Иванович','1998-03-24', 2);

INSERT INTO Attractions (Name, Description, Capacity, TicketPrice)
VALUES
    ('Змей Горыныч', 'Экстримальный аттракцион, американская горка', 20, 500),
    ('Колесо обозрения', 'Высокое колесо, крутящееся по кругу', 15, 400),
    ('Лодочки', 'Качели-лодочки', 25, 600),
    ('Американские горки','Высокие горки с крутыми поворотами',30,550),
    ('Карусели','Вращающиеся карусели с лошадками',20,450);

INSERT INTO Tickets (PurchaseDate, AttractionId)
VALUES
    ('2020-01-01', 1),
    ('2020-02-14', 2),
    ('2020-03-28', 3),
    ('2020-04-15', 1),
    ('2020-05-23', 3),
    ('2020-06-12', 4);

INSERT INTO TicketAttractions (TicketId, AttractionId)
VALUES
    (1, 1),
    (2, 2),
    (3, 3),
    (4, 1),
    (5, 3),
    (6, 4);

INSERT INTO TicketSales (TicketId, EmployeeId, SaleTime)
VALUES
    (1, 1, '2020-01-01 10:00'),
    (2, 2, '2020-02-14 11:30'),
    (3, 3, '2020-03-28 15:45'),
    (4, 2, '2020-04-15 12:35'),
    (5, 4, '2020-05-23 16:10'),
    (6, 3, '2020-06-12 09:25');
