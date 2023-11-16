CREATE TABLE UserCredentials (
    Id SERIAL PRIMARY KEY,
    Login TEXT NOT NULL UNIQUE,
    Password TEXT NOT NULL
);

CREATE TABLE Attractions (
     id SERIAL PRIMARY KEY,
     Name TEXT NOT NULL,
     Description TEXT NOT NULL,
     Capacity INTEGER NOT NULL,
     TicketPrice INTEGER NOT NULL
);

CREATE TABLE Positions (
    Id SERIAL PRIMARY KEY,
    Position TEXT NOT NULL,
    Salary INTEGER NOT NULL,
    Count INTEGER NOT NULL
);

CREATE TABLE Tickets (
    Id SERIAL PRIMARY KEY,
    PurchaseDate DATE NOT NULL,
    AttractionID INTEGER NOT NULL,
    FOREIGN KEY (AttractionID) REFERENCES Attractions(id)
);

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
    FirstName TEXT NOT NULL,
    LastName TEXT NOT NULL,
    DateOfBirth DATE NOT NULL,
    PositionID INTEGER NOT NULL,
    
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