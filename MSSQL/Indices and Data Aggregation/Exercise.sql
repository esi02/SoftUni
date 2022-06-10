--01. Records’ Count
SELECT COUNT(*) AS Count FROM WizzardDeposits

--02. Longest Magic Wand
SELECT 
MAX(w.MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits AS w

--03. Longest Magic Wand per Deposit Groups
SELECT 
w.DepositGroup, MAX(w.MagicWandSize) AS LongestMagicWand
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup

--04. Smallest Deposit Group per Magic Wand Size
SELECT TOP 2
w.DepositGroup
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup
ORDER BY AVG(w.MagicWandSize)

--05. Deposits Sum
SELECT
w.DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup

--06. Deposits Sum for Ollivander Family
SELECT
w.DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits AS w
WHERE w.MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup

--07. Deposits Filter
SELECT
w.DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits AS w
WHERE w.MagicWandCreator = 'Ollivander family'
GROUP BY w.DepositGroup
HAVING SUM(w.DepositAmount) < 150000
ORDER BY TotalSum DESC

--08. Deposit Charge
SELECT
w.DepositGroup, w.MagicWandCreator, MIN(w.DepositCharge) AS MinDepositCharge
FROM WizzardDeposits AS w
GROUP BY w.DepositGroup, w.MagicWandCreator

--09. Age Groups
SELECT AgeGroups, COUNT(*) AS WizardCount
FROM
(SELECT
CASE
WHEN w.Age >= 0 AND w.Age <= 10 THEN  '[0-10]'
WHEN w.Age >= 11 AND w.Age <= 20 THEN '[11-20]'
WHEN w.Age >= 21 AND w.Age <= 30 THEN '[21-30]'
WHEN w.Age >= 31 AND w.Age <= 40 THEN '[31-40]'
WHEN w.Age >= 41 AND w.Age <= 50 THEN '[41-50]'
WHEN w.Age >= 51 AND w.Age <= 60 THEN '[51-60]'
ELSE '[61+]' 
END AS AgeGroups
FROM WizzardDeposits AS w) t
GROUP BY AgeGroups

--10. First Letter
SELECT DISTINCT
SUBSTRING(w.FirstName, 1, 1) AS FirstLetter
FROM WizzardDeposits AS w
WHERE w.DepositGroup = 'Troll Chest'
ORDER BY FirstLetter

--11. Average Interest
SELECT 
w.DepositGroup, w.IsDepositExpired, AVG(w.DepositInterest) AS DepositInterest
FROM WizzardDeposits AS w
WHERE w.DepositStartDate > '1985-01-01'
GROUP BY w.DepositGroup, w.IsDepositExpired
ORDER BY w.DepositGroup DESC

--13. Departments Total Salaries
SELECT
e.DepartmentID, SUM(e.Salary) AS TotalSalary
FROM Employees AS e
GROUP BY e.DepartmentID;

--14. Employees Minimum Salaries
SELECT
e.DepartmentID, MIN(e.Salary) AS MinimumSalary
FROM Employees AS e
WHERE e.HireDate > '2000-01-01'
GROUP BY e.DepartmentID
HAVING e.DepartmentID IN(2,5,7);

--15. Employees Average Salaries
SELECT * INTO NewTable
FROM Employees AS e
WHERE e.Salary > 30000;

DELETE FROM NewTable
WHERE ManagerID = 42;

UPDATE NewTable
SET Salary += 5000
WHERE DepartmentID = 1;

SELECT
t.DepartmentID, AVG(t.Salary) AS AverageSalary
FROM NewTable AS t
GROUP BY t.DepartmentID;

--16. Employees Maximum Salaries
SELECT
e.DepartmentID, MAX(e.Salary) AS MaxSalary
FROM Employees AS e
GROUP BY e.DepartmentID
HAVING MAX(e.Salary) NOT BETWEEN 30000 AND 70000

--17. Employees Count Salaries
SELECT
COUNT(e.Salary) AS Count
FROM Employees AS e
WHERE e.ManagerID IS NULL