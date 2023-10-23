# Курсовая работа по базам данных

# Оглавление
1. [Работа с базой данных](#работа-с-базой-данных)

## Работа с базой данных
#### Была создана база данных [sb_14.db](DbAppSb/DbAppSb/sb_14.db) с таблицами:
```
CREATE TABLE "Attractions" (
	"id"	INTEGER NOT NULL UNIQUE,
	"Name"	TEXT NOT NULL,
	"Description"	TEXT NOT NULL,
	"Capacity"	INTEGER NOT NULL,
	"TicketPrice"	INTEGER NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "Tickets" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"PurchaseDate"	DATE NOT NULL,
	"AttractionID"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
	FOREIGN KEY("AttractionID") REFERENCES "Attractions"("id")
);

CREATE TABLE "Positions" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Position"	TEXT NOT NULL,
	"Salary"	INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

CREATE TABLE "Employees" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Login"	TEXT NOT NULL UNIQUE,
	"Password"	TEXT NOT NULL,
	"FirstName"	TEXT NOT NULL,
	"LastName"	TEXT NOT NULL,
	"DateOfBirth"	DATE NOT NULL,
	"PositionID" INTEGER NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT),
    FOREIGN KEY("PositionID") REFERENCES "Positions"("id")
);

CREATE TABLE "TicketSales" (
    "Id" INTEGER PRIMARY KEY AUTOINCREMENT,
    "TicketId" INTEGER NOT NULL UNIQUE,
    "EmployeeId" INTEGER NOT NULL,
    "SaleTime" DATETIME NOT NULL,

    FOREIGN KEY ("TicketId") REFERENCES "Tickets"("Id"),
    FOREIGN KEY ("EmployeeId") REFERENCES "Employees"("Id")
);

```
### Зависимости таблиц:
![зависимости таблиц](images/diagram.png)</br>

`SELECT * FROM Employees;`
![Employees](images/employees.png)</br>

`SELECT * FROM Positions;`
![Employees](images/positions.png)</br>

`SELECT * FROM Attractions;`
![Employees](images/attractions.png)</br>

`SELECT * FROM Tickets;`
![Employees](images/tickets.png)</br>

`SELECT * FROM TicketSales;`
![Employees](images/ticketSales.png)</br>



