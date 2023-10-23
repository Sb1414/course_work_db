INSERT INTO Attractions (Name, Description, Capacity, TicketPrice)
VALUES
    ('Американские горки', 'Быстрые американские горки с петлями', 20, 500),
    ('Колесо обозрения', 'Медленное колесо обозрения с великолепными видами', 30, 200),
    ('Бамперные машины', 'Поездка на бамперной машине по арене', 10, 120);

INSERT INTO Tickets (PurchaseDate, AttractionID)
VALUES
    (DATE('now')-2, 1),
    (DATE('now')-2, 2),
    (DATE('now')-2, 3),
    (DATE('now')-2, 1),
    (DATE('now')-1, 2),
    (DATE('now')-1, 2),
    (DATE('now')-1, 3),
    (DATE('now')-1, 3),
    (DATE('now'), 1),
    (DATE('now'), 2),
    (DATE('now'), 3),
    (DATE('now'), 3);

INSERT INTO Positions (Position, Salary)
VALUES
    ('Стажер', 15000),
    ('Кассир-оператор', 35000);

INSERT INTO Employees (Login, Password, FirstName, LastName, DateOfBirth, PositionID)
VALUES
    ('sb', 'sb14', 'Сабина', 'Калкаманова', '2003-03-14', '1'),
    ('jane456', 'password456', 'Виктория', 'Иванова', '1985-03-15', '1'),
    ('test', 'test', 'Иван', 'Иванов', '1985-03-25', '1'),
    ('employee1', 'password1', 'Виктор', 'Викторов', '1990-05-15', '2'),
    ('employee2', 'password2', 'Данил', 'Данилов', '1985-12-10', '2'),
    ('employee3', 'password3', 'Степан', 'Степанов', '1995-03-20', '2');

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales) , 1, DATETIME('now', '-9 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 1, DATETIME('now', '-7 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 2, DATETIME('now', '-12 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 2, DATETIME('now', '-11 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 3, DATETIME('now', '-7 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 1, DATETIME('now', '-4 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 2, DATETIME('now', '-3 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 4, DATETIME('now', '-5 hours'));

INSERT INTO TicketSales (TicketID, EmployeeID, SaleTime)
VALUES ((SELECT COALESCE(MAX(TicketId), 0) + 1 FROM TicketSales), 4, DATETIME('now', '-4 hours'));