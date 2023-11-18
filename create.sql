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

CREATE TABLE Tickets (
    Id SERIAL PRIMARY KEY,
    PurchaseDate DATE NOT NULL,
    AttractionID INTEGER NOT NULL,
    FOREIGN KEY (AttractionID) REFERENCES Attractions(id)
);

ALTER TABLE tickets
    DROP CONSTRAINT IF EXISTS tickets_attractionid_fkey;

-- Удаление таблицы
DROP TABLE IF EXISTS tickets;

-- Создание таблицы заново
CREATE TABLE Tickets (
    Id SERIAL PRIMARY KEY,
    PurchaseDate DATE NOT NULL,
    AttractionID INTEGER NOT NULL,
    FOREIGN KEY (AttractionID) REFERENCES Attractions(id) ON DELETE CASCADE
);

-- 
-- ALTER TABLE tickets
--     ADD CONSTRAINT tickets_attractionid_fkey
--         FOREIGN KEY (AttractionID)
--             REFERENCES Attractions(id)
--             ON DELETE CASCADE;


CREATE TABLE TicketAttractions (
    TicketId INTEGER NOT NULL,
    AttractionID INTEGER NOT NULL,
    
    PRIMARY KEY (TicketId, AttractionID),
    FOREIGN KEY (TicketId) REFERENCES Tickets(Id),
    FOREIGN KEY (AttractionID) REFERENCES Attractions(id)
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

CREATE TABLE TicketSales (
    Id SERIAL PRIMARY KEY,
    TicketId INTEGER NOT NULL,
    EmployeeId INTEGER NOT NULL,
    SaleTime TIMESTAMP NOT NULL,
    
    FOREIGN KEY (TicketId) REFERENCES Tickets(Id),
    FOREIGN KEY (EmployeeId) REFERENCES Employees(Id)
);