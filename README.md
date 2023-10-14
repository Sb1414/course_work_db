# Курсовая работа по базам данных

# Оглавление
1. [Работа с базой данных](#работа-с-базой-данных)

## Работа с базой данных
#### Была создана база данных [sb_14.db](DbAppSb/DbAppSb/sb_14.db) с таблицами:
```
CREATE TABLE Employees (
    Id INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DateOfBirth DATE,
    Position VARCHAR(50),
    Salary DECIMAL(10, 2)
);

CREATE TABLE Shifts (
    Id INT PRIMARY KEY,
    EmployeeID INT,
    StartTime DATETIME,
    EndTime DATETIME,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(Id)
);

CREATE TABLE Attractions (
    Id INT PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT,
    Capacity INT,
    TicketPrice DECIMAL(10, 2)
);

CREATE TABLE Tickets (
    Id INT PRIMARY KEY,
    PurchaseDate DATE,
    AttractionID INT,
    FOREIGN KEY (AttractionID) REFERENCES Attractions(Id)
);
```
#### в приложении созданы соответствующие классы для работы с базой данных: [Employee](DbAppSb/DbAppSb/Employee.cs), [Attraction](DbAppSb/DbAppSb/Attraction.cs), [Shift](DbAppSb/DbAppSb/Shift.cs), [Ticket](DbAppSb/DbAppSb/Ticket.cs)