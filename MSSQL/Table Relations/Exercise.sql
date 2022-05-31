--01. One-To-One Relationship
CREATE TABLE Passports
(
	PassportID INT  PRIMARY KEY IDENTITY(101,1)
	,PassportNumber VARCHAR(10) UNIQUE NOT NULL
)

CREATE TABLE Persons
(
	PersonID INT PRIMARY KEY IDENTITY
	,FirstName VARCHAR(50) NOT NULL
	,Salary DECIMAL(10,2) NOT NULL
	,PassportID INT FOREIGN KEY REFERENCES Passports(PassportID) UNIQUE NOT NULL
)

INSERT INTO Passports(PassportNumber) VALUES
	('N34FG21B')
	,('K65LO4R7')
	,('ZE657QP2')

INSERT INTO Persons(FirstName, Salary, PassportID) VALUES
	('Roberto', 43300.00, 102)
	,('Tom', 56100.00, 103)
	,('Yana', 60200.00, 101)
	
	--02. One-To-Many Relationship
	CREATE TABLE Manufacturers (
ManufacturerID INT PRIMARY KEY,
Name VARCHAR(10) NOT NULL,
EstablishedOn DATE NOT NULL
);

CREATE TABLE Models (
ModelID INT IDENTITY(101,1) PRIMARY KEY,
Name VARCHAR(50) NOT NULL, 
ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
);

--03. Many-To-Many Relationship
CREATE TABLE Students (
StudentID INT IDENTITY PRIMARY KEY,
Name VARCHAR(10) NOT NULL
);

CREATE TABLE Exams(
ExamID INT IDENTITY(101, 1) PRIMARY KEY,
Name VARCHAR(50) NOT NULL
);

CREATE TABLE StudentsExams(
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),
PRIMARY KEY (StudentID, ExamID)
);

INSERT INTO Students(Name)
VALUES ('Mila'),('Toni'),('Ron');

INSERT INTO Exams(Name)
VALUES ('SpringMVC'),('Neo4j'),('Oracle 11g');

--04. Self-Referencing
CREATE TABLE Teachers(
TeacherID INT IDENTITY(101,1) PRIMARY KEY,
Name VARCHAR(10) NOT NULL,
ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
);

INSERT INTO Teachers (Name, ManagerID)
VALUES('John', NULL), ('Maya', 106), ('Silvia', 106),('Ted', 105),('Mark', 101),('Greta',101);

--05. Online Store Database
CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY(1,1)
	,[Name] VARCHAR(50) NOT NULL
)

CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY(1,1)
	,[Name] VARCHAR(50) NOT NULL
)


CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY(1,1)
	,[Name] VARCHAR(50) NOT NULL
	,ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Customers
(

    CustomerID INT PRIMARY KEY IDENTITY(1,1)
	,[Name] VARCHAR(50) NOT NULL
	,Birthday DATE
	,CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)

CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY (1,1)
	,CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems
(
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID)
	,ItemID INT FOREIGN KEY REFERENCES Items(ItemID)
	,CONSTRAINT INT PRIMARY KEY (OrderID, ItemID)
)

--06. University Database
CREATE TABLE Majors(
MajorID INT IDENTITY PRIMARY KEY,
Name VARCHAR(20)
);

CREATE TABLE Students(
StudentID INT IDENTITY PRIMARY KEY,
StudentNumber INT,
StudentName VARCHAR(20),
MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
);

CREATE TABLE Subjects(
SubjectID INT IDENTITY PRIMARY KEY,
SubjectName VARCHAR(20)
);

CREATE TABLE Agenda(
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
PRIMARY KEY (StudentID, SubjectID)
);

CREATE TABLE Payments(
PaymentID INT IDENTITY PRIMARY KEY,
PaymentDate DATE, 
PaymentAmount DECIMAL (2,0),
StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
);

--09. *Peaks in Rila
SELECT MountainRange, PeakName, Elevation
  FROM Peaks, Mountains
  WHERE MountainRange = 'Rila' AND MountainId=17
  ORDER BY Elevation DESC;