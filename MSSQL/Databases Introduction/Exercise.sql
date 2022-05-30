--04. Insert Records in Both Tables

INSERT INTO Towns (Id, Name)
VALUES 
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna');

INSERT INTO Minions (Id, Name, Age, TownId)
VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2);

--07. Create Table People

CREATE TABLE People
(Id INT NOT NULL IDENTITY,
Name CHAR(200) NOT NULL, 
Picture IMAGE,
Height DECIMAL(2),
Weight DECIMAL(2),
Gender CHAR(1) check (gender in ('m', 'f')) NOT NULL,
Birthdate DATETIME NOT NULL,
Biography VARCHAR(MAX));

INSERT INTO People (Name, Gender, Birthdate)
VALUES
('Kevin', 'm', '1998-01-23 12:45:56'),
('Suzan', 'f', '1998-01-23 12:45:56'),
('Bob', 'm', '1998-01-23 12:45:56'),
('Hutch', 'm', '1998-01-23 12:45:56'),
('Sue', 'f', '1998-01-23 12:45:56');

--08. Create Table Users

CREATE TABLE Users
(Id BIGINT NOT NULL IDENTITY,
Username CHAR(30) NOT NULL,
Password CHAR(26) NOT NULL,
ProfilePicture IMAGE,
LastLoginTime DATETIME,
IsDeleted CHAR(5) check (isdeleted in ('true', 'false')) NOT NULL);

INSERT INTO Users (Username, Password, IsDeleted)
VALUES
('Kevin', 'pass@123', 'false'),
('Suzan', 'pass@123', 'false'),
('Bob', 'pass@123', 'false'),
('Hutch', 'pass@123', 'false'),
('Sue', 'pass@123', 'false');

--13. Movies Database

CREATE TABLE Directors(
Id INT NOT NULL IDENTITY,
DirectorName CHAR(50) NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Genres(
Id INT NOT NULL IDENTITY,
GenreName CHAR(50) NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Categories(
Id INT NOT NULL IDENTITY,
CategoryName CHAR(50) NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Movies(
Id INT NOT NULL IDENTITY,
Title CHAR(50) NOT NULL,
DirectorId INT NOT NULL,
CopyrightYear DATETIME,
Length INT,
GenreId INT NOT NULL,
CategoryId INT NOT NULL,
Rating INT,
Notes VARCHAR(MAX)
);

INSERT INTO Directors (DirectorName)
VALUES 
('Kevin'),
('Stewart'),
('Kevin'),
('Stewart'),
('Kevin');

INSERT INTO Genres (GenreName)
VALUES 
('Fantasy'),
('Sci-Fi'),
('Drama'),
('Comedy'),
('Action');

INSERT INTO Categories (CategoryName)
VALUES 
('Gold'),
('Silver'),
('Bronze'),
('Iron'),
('Rock');

INSERT INTO Movies (Title, DirectorId, GenreId, CategoryId)
VALUES 
('Movie1', 1, 2, 3),
('Movie1', 2, 1, 3),
('Movie1', 3, 2, 1),
('Movie1', 1, 2, 3),
('Movie1', 1, 2, 3);

--14. Car Rental Database

create table Categories (
Id INT NOT NULL IDENTITY,
CategoryName CHAR(50) NOT NULL,
DailyRate INT,
WeeklyRate INT,
MonthlyRate INT NOT NULL,
WeekendRate INT
);

create table Cars(
Id INT NOT NULL IDENTITY,
PlateNumber CHAR(10) NOT NULL,
Manufacturer CHAR(50) NOT NULL,
Model CHAR(50),
CarYear INT NOT NULL,
CategoryId INT NOT NULL,
Doors INT,
Picture IMAGE,
Condition CHAR(10) NOT NULL,
Available CHAR(5) NOT NULL);

CREATE TABLE Employees (
Id INT NOT NULL IDENTITY,
FirstName CHAR (10) NOT NULL,
LastName CHAR (10),
Title CHAR(10) NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Customers (
Id INT NOT NULL IDENTITY,
DriversLicenceNumber CHAR (10) NOT NULL,
FullName CHAR (50) NOT NULL,
Address CHAR(50),
City CHAR(10),
ZIPCode CHAR(5),
Notes VARCHAR(MAX)
);

CREATE TABLE RentalOrders (
Id INT NOT NULL IDENTITY,
EmployeeId INT NOT NULL,
CarId INT NOT NULL,
TankLevel INT,
KilometrageStart INT,
KilometrageEnd INT,
TotalKilometrage INT,
StartDate DATETIME,
EndDate DATETIME,
TotalDays INT,
RateApplied INT,
TaxRate INT,
OrderStatus CHAR(10),
Notes VARCHAR(MAX)
);

INSERT INTO Cars(PlateNumber, Manufacturer, CarYear, CategoryId, Condition, Available)
VALUES
('A8777H', 'Mercedez', '2008', 2, 'Used', 'true'),
('A8555H', 'Benz', '2006', 2, 'Used', 'true'),
('A8444H', 'Fiat', '2010', 2, 'Used', 'true');

INSERT INTO Categories(CategoryName, MonthlyRate)
VALUES
('Fast', 5),
('Fast', 8),
('Medium', 7);

INSERT INTO Employees(FirstName, Title)
VALUES
('test', 'manager'),
('test', 'finances'),
('test', 'finances');

INSERT INTO Customers(DriversLicenceNumber, FullName)
VALUES
('5555', 'Test'),
('4444', 'Test1'),
('3333', 'test2');

INSERT INTO RentalOrders(EmployeeId, CarId)
VALUES
(3, 5),
(2, 8),
(1, 7);

--15. Hotel Database

CREATE TABLE Employees(
Id INT NOT NULL,
FirstName CHAR(100) NOT NULL,
LastName CHAR(100),
Title CHAR(50),
Notes VARCHAR(MAX)
);

CREATE TABLE Customers(
AccountNumber INT NOT NULL,
FirstName CHAR(100) NOT NULL,
LastName CHAR(100),
PhoneNumber INT,
EmergencyName CHAR(100),
EmergencyNumber INT NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE RoomStatus(
RoomStatus CHAR(10),
Notes VARCHAR(MAX)
);

CREATE TABLE RoomTypes(
RoomType CHAR(10),
Notes VARCHAR(MAX)
);
CREATE TABLE BedTypes(
BedType CHAR(10),
Notes VARCHAR(MAX)
);

CREATE TABLE Rooms(
RoomNumber INT,
RoomType CHAR(10),
BedType CHAR(10),
Rate INT,
RoomStatus CHAR(10),
Notes VARCHAR(MAX)
);

CREATE TABLE Payments(
Id INT NOT NULL IDENTITY,
EmployeeId INT NOT NULL,
PaymentDate DATETIME,
AccountNumber INT NOT NULL,
FirstDateOccupied DATETIME,
LastDateOccupied DATETIME,
TotalDays INT,
AmountCharged DECIMAL,
TaxRate INT,
TaxAmount INT,
PaymentTotal DECIMAL NOT NULL,
Notes VARCHAR(MAX)
);

CREATE TABLE Occupancies(
Id INT NOT NULL IDENTITY,
EmployeeId INT NOT NULL,
DateOccupied DATETIME,
AccountNumber INT NOT NULL,
RoomNumber INT,
RateApplied INT,
PhoneCharge CHAR(5),
Notes VARCHAR(MAX)
);

INSERT INTO Employees(Id, FirstName)
VALUES
(1, 'test1'),
(2, 'test2'),
(3, 'test3');

INSERT INTO Customers(AccountNumber, FirstName, EmergencyNumber)
VALUES
(555, 'Test', 1),
(555, 'Test', 2),
(555, 'Test', 4);

INSERT INTO RoomStatus(RoomStatus)
VALUES
('good'),
('good'),
('good');

INSERT INTO RoomTypes(RoomType)
VALUES
('triangle'),
('square'),
('rectangle');

INSERT INTO BedTypes(BedType)
VALUES
('triangle'),
('square'),
('rectangle');

INSERT INTO Rooms(RoomNumber, Rate)
VALUES
(1, 5),
(2, 4),
(3, 5);

INSERT INTO Payments(EmployeeId, AccountNumber, PaymentTotal)
VALUES
(1, 555, 50.20),
(2, 444, 100.93),
(3, 333, 50.98);

INSERT INTO Occupancies(EmployeeId, AccountNumber)
VALUES
(1, 555),
(2, 444),
(3, 333);

--19. Basic Select All Fields

select * from towns;
select * from departments;
select * from employees;

--20. Basic Select All Fields and Order

select * from towns
order by Name;
select * from departments
order by Name;
select * from employees
order by salary desc;

--21. Basic Select Some Fields

select name from towns
order by name;
select name from departments
order by name;
select firstname, lastname, jobtitle, salary from employees
order by salary desc;

--22. Increase Employees Salary

update  employees
set salary = salary * 1.10;
select salary from employees;

--23. Decrease Tax Rate

update payments
set paymenttotal = taxrate * 0.03;
select taxrate from payments;

--24. Delete All Records

delete from occupancies;