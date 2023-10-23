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

CREATE TABLE "Employees" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"Login"	TEXT NOT NULL UNIQUE,
	"Password"	TEXT NOT NULL,
	"FirstName"	TEXT NOT NULL,
	"LastName"	TEXT NOT NULL,
	"DateOfBirth"	DATE NOT NULL,
	PRIMARY KEY("Id" AUTOINCREMENT)
);

CREATE TABLE "Shifts" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"EmployeeID"	INTEGER NOT NULL UNIQUE,
	"StartTime"	DateTime NOT NULL,
	"EndTime"	DATETIME NOT NULL,
	"Position"	TEXT NOT NULL,
	"Salary"	INTEGER NOT NULL,
	FOREIGN KEY("EmployeeID") REFERENCES "Employees"("Id"),
	PRIMARY KEY("Id" AUTOINCREMENT)
);

```
![зависимости таблиц](images/diagram.png)</br>
