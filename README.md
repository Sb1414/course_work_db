# Курсовая работа по базам данных

# Оглавление
1. [Работа с базой данных](#работа-с-базой-данных)

## Работа с базой данных
#### Была создана база данных [sb_14.db](DbAppSb/DbAppSb/sb_14.db) с таблицами:
```
CREATE TABLE UserCredentials (
    Id SERIAL PRIMARY KEY,
    Login VARCHAR NOT NULL UNIQUE,
    Password VARCHAR NOT NULL
);

CREATE TABLE Attractions (
     id SERIAL PRIMARY KEY,
     Name VARCHAR NOT NULL,
     Description VARCHAR NOT NULL,
     Capacity INTEGER NOT NULL,
     TicketPrice INTEGER NOT NULL
);

CREATE TABLE Positions (
    Id SERIAL PRIMARY KEY,
    Position VARCHAR NOT NULL,
    Salary INTEGER NOT NULL,
    Count INTEGER NOT NULL
);

CREATE TABLE Employees (
    Id SERIAL PRIMARY KEY,
    UserCredentialId INTEGER NOT NULL,
    FirstName VARCHAR NOT NULL,
    LastName VARCHAR NOT NULL,
    MiddleName VARCHAR NOT NULL,
    DateOfBirth DATE NOT NULL,
    PositionID INTEGER,
    
    FOREIGN KEY (UserCredentialId) REFERENCES UserCredentials(Id),
    FOREIGN KEY (PositionID) REFERENCES Positions(Id)
);

CREATE TABLE Tickets (
    Id SERIAL PRIMARY KEY,
    PurchaseDate DATE NOT NULL,
    EmployeeId INTEGER NOT NULL,
    
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
);

CREATE TABLE TicketAttractions (
    TicketId INTEGER NOT NULL,
    AttractionID INTEGER NOT NULL,
    
    PRIMARY KEY (TicketId, AttractionID),
    FOREIGN KEY (TicketId) REFERENCES Tickets(Id),
    FOREIGN KEY (AttractionID) REFERENCES Attractions(id)
);

```
### Зависимости таблиц:
![зависимости таблиц](images/diagram.png)</br>


