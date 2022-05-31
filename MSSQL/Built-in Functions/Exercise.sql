--01. Find Names of All Employees by First Name
SELECT FirstName, LastName FROM Employees
WHERE FirstName LIKE 'Sa%'

--02. Find Names of All Employees by Last Name
SELECT FirstName, LastName FROM Employees
WHERE LastName LIKE '%ei%'

--03. Find First Names of All Employess
SELECT FirstName FROM Employees
WHERE DepartmentID = 3 OR DepartmentID = 10
AND DATEPART(year, HireDate) BETWEEN 1995 AND 2005;

--04. Find All Employees Except Engineers
SELECT FirstName, LastName FROM Employees
WHERE CHARINDEX('Engineer', JobTitle, 1) = 0;

--05. Find Towns with Name Length
SELECT Name
FROM Towns
WHERE LEN(Name) = 5 OR LEN(NAME) = 6
ORDER BY Name

--06. Find Towns Starting With
SELECT *
FROM Towns
WHERE SUBSTRING(Name, 1, 1) IN ('M','K','B','E')
ORDER BY Name ASC

--07. Find Towns Not Starting With
SELECT *
FROM Towns
WHERE SUBSTRING(Name, 1, 1) NOT IN ('R','B','D')
ORDER BY Name ASC

--08. Create View Employees Hired After
CREATE VIEW V_EmployeesHiredAfter2000 AS
SELECT FirstName, LastName
FROM Employees
Where DATEPART(YEAR, HireDate) > 2000

--09. Length of Last Name
SELECT FirstName, LastName
FROM Employees
Where LEN(LastName) = 5

--10. Rank Employees by Salary
 SELECT EmployeeID, FirstName, LastName, Salary
   	  ,DENSE_RANK() OVER (PARTITION BY Salary ORDER BY EmployeeID) AS [Rank]
    FROM Employees
   WHERE Salary BETWEEN 10000 AND 50000
ORDER BY Salary DESC

--11. Find All Employees with Rank 2
 SELECT * FROM ( SELECT 
 EmployeeID, 
 FirstName, 
 LastName, 
 Salary,
		DENSE_RANK() OVER (
	  PARTITION BY Salary
	  ORDER BY EmployeeID) Rank
    FROM Employees) t
 WHERE Salary BETWEEN 10000 AND 50000 AND Rank = 2
 ORDER BY Salary DESC;
 
 --12. Countries Holding 'A'
SELECT CountryName, IsoCode 
  FROM Countries
 WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode

--13. Mix of Peak and River Names
SELECT PeakName, RiverName, LOWER(
CONCAT(
LEFT(PeakName, LEN(PeakName) - 1),
RiverName
)) AS Mix
FROM Peaks, Rivers
WHERE SUBSTRING(REVERSE(PeakName), 1, 1) = SUBSTRING(RiverName, 1, 1)
ORDER BY Mix;

--14. Games From 2011 and 2012 Year
SELECT TOP 50 Name, FORMAT(Start, 'yyyy-MM-dd') AS Start
FROM Games
WHERE DATEPART(year, Start) IN ('2011', '2012')
ORDER BY Start, Name;

--15. User Email Providers
SELECT Username, RIGHT(Email, CHARINDEX('@', REVERSE(Email)) - 1) AS EmailProvider
FROM Users
ORDER BY EmailProvider, Username;

--16. Get Users with IPAddress Like Pattern
SELECT Username, IpAddress
FROM Users
WHERE IpAddress LIKE '___.1%.%.___'
ORDER BY Username;

--17. Show All Games with Duration
SELECT [Name] AS Game,
CASE 
WHEN DATEPART(hour, Start) BETWEEN 0 AND 11 THEN 'Morning'
WHEN DATEPART(hour, Start) BETWEEN 12 AND 17 THEN 'Afternoon'
WHEN DATEPART(hour, Start) BETWEEN 18 AND 23 THEN 'Evening'
END AS [Part of the Day],
CASE
WHEN Duration <= 3 THEN 'Extra Short'
WHEN Duration >= 4 AND Duration <=6 THEN 'Short'
WHEN Duration > 6 THEN 'Long'
ELSE 'Extra Long'
END AS [Duration]
FROM Games
ORDER BY Game, Duration, [Part of the Day];

--18. Orders Table
SELECT ProductName, OrderDate,
DATEADD(day, 3, OrderDate) AS [Pay Due],
DATEADD(month, 1, OrderDate) AS [Deliver Due]
FROM Orders;