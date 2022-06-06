--01. Employee Address
SELECT TOP 5
EmployeeId, JobTitle, e.AddressID, a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
ORDER BY e.AddressID;

--02. Addresses with Towns
SELECT TOP 50
FirstName, LastName, t.Name AS Town, a.AddressText
FROM Employees AS e
JOIN Addresses AS a ON e.AddressID = a.AddressID
JOIN Towns AS t ON t.TownID = a.TownID
ORDER BY e.FirstName, e.LastName;

--03. Sales Employees
SELECT 
EmployeeID, FirstName, LastName, d.Name AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'
ORDER BY e.EmployeeID;

--04. Employee Departments
SELECT TOP 5
EmployeeID, FirstName, Salary, d.Name AS DepartmentName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE Salary > 15000
ORDER BY e.DepartmentID;

--05. Employees Without Projects
SELECT TOP 3
e.EmployeeID, FirstName
FROM Employees AS e
FULL OUTER JOIN EmployeesProjects AS p ON e.EmployeeID = p.EmployeeID
WHERE p.ProjectID IS NULL
ORDER BY e.EmployeeID;

--06. Employees Hired After
SELECT 
FirstName, LastName, HireDate, d.Name AS DeptName
FROM Employees AS e
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN ('Sales', 'Finance') AND
HireDate > '1999-01-01'
ORDER BY HireDate;

--07. Employees With Project
SELECT TOP 5
e.EmployeeID, e.FirstName, p.Name AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON ep.EmployeeID = e.EmployeeID
JOIN Projects AS p ON ep.ProjectID = p.ProjectID
WHERE p.StartDate > '2002-08-13' AND p.EndDate IS NULL
ORDER BY e.EmployeeID;

--08. Employee 24
SELECT
e.EmployeeID, e.FirstName,
CASE
WHEN DATEPART(year, p.StartDate) >= 2005 THEN NULL
ELSE p.Name
END AS ProjectName
FROM Employees AS e
JOIN EmployeesProjects AS ep ON e.EmployeeID = ep.EmployeeID
JOIN Projects AS p ON p.ProjectID = ep.ProjectID
WHERE e.EmployeeID = 24

--09. Employee Manager
SELECT
e.EmployeeID, e.FirstName, e.ManagerID, m.FirstName AS ManagerName
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
WHERE e.ManagerID IN (3,7)
ORDER BY e.EmployeeID

--10. Employees Summary
SELECT TOP 50
e.EmployeeID,
CONCAT_WS(' ', e.FirstName, e.LastName) AS EmployeeName,
CONCAT_WS(' ', m.FirstName, m.LastName) AS ManagerName,
d.Name AS DepartmentName
FROM Employees AS e
JOIN Employees AS m ON e.ManagerID = m.EmployeeID
JOIN Departments AS d ON e.DepartmentID = d.DepartmentID
ORDER BY e.EmployeeID;

--11. Min Average Salary
SELECT
MIN(avg) AS MinAverageSalary FROM (
SELECT AVG(Salary) AS avg
FROM Employees AS e
GROUP BY DepartmentID ) AS AverageSalary

--12. Highest Peaks in Bulgaria
SELECT
c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
FROM Peaks AS p
JOIN Mountains AS m ON p.MountainId = m.Id
JOIN MountainsCountries AS c ON p.MountainId = c.MountainId
WHERE c.CountryCode = 'BG' AND
p.Elevation > 2835
ORDER BY p.Elevation DESC

--13. Count Mountain Ranges
SELECT
codes AS CountryCode, ranges AS MountainRanges FROM (
SELECT COUNT(m.MountainId) AS ranges, m.CountryCode AS codes
FROM MountainsCountries as m
GROUP BY m.CountryCode
) AS rgs
WHERE codes IN ('BG', 'RU', 'US')

--14. Countries With or Without Rivers
SELECT TOP 5
c.CountryName, ISNULL(r.RiverName, NULL) AS RiverName
FROM Countries AS c
FULL OUTER JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
FULL OUTER JOIN Rivers AS r ON cr.RiverId = r.Id
WHERE c.ContinentCode IN ('AF')
ORDER BY c.CountryName

--15. Continents and Currencies
SELECT ContinentCode, CurrencyCode, Result AS CurrencyUsage
  FROM (
     SELECT 
    	 c.ContinentCode
    	,c.CurrencyCode
    	,COUNT(c.CurrencyCode) AS Result
		,DENSE_RANK() OVER (PARTITION BY c.ContinentCode ORDER BY COUNT(c.CurrencyCode) DESC) AS Rank
     FROM Countries c
	GROUP BY ContinentCode, CurrencyCode) AS gr
WHERE gr.Rank = 1 AND gr.Result > 1
ORDER BY ContinentCode

--16. Countries Without any Mountains
SELECT COUNT(c.CountryCode) AS Count
FROM MountainsCountries AS m
FULL OUTER JOIN Countries AS c ON m.CountryCode = c.CountryCode
WHERE m.MountainId IS NULL

--17. Highest Peak and Longest River by Country
SELECT TOP 5
c.CountryName,
MAX(p.Elevation) AS HighestPeakElevation,
MAX(r.Length) AS LongestRiverLength
FROM Peaks AS p
FULL OUTER JOIN MountainsCountries AS mc ON p.MountainId = mc.MountainId
FULL OUTER JOIN Countries AS c ON mc.CountryCode = c.CountryCode
FULL OUTER JOIN CountriesRivers AS cr ON c.CountryCode = cr.CountryCode
FULL OUTER JOIN Rivers AS r ON cr.RiverId = r.Id
GROUP BY c.CountryName
ORDER BY HighestPeakElevation DESC, 
LongestRiverLength DESC,
CountryName