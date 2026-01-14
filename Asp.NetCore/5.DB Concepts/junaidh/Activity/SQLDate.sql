create database datetimee


CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(50),
    BirthDate DATE
);

INSERT INTO Customers VALUES
(1, 'Arjun', 'arjun@gmail.com', '1998-01-04'),
(2, 'Meera', 'meera@gmail.com', '1996-06-15'),
(3, 'Rahul', 'rahul@gmail.com', '1995-12-10');

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    Product VARCHAR(50),
    OrderDate DATETIME,
    Amount DECIMAL(10,2),
    LastOrderDate DATETIME,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Orders VALUES
(101, 1, 'Laptop', DATEADD(DAY, -3, GETDATE()), 55000, DATEADD(DAY, -3, GETDATE())),
(102, 2, 'Mobile', DATEADD(DAY, -15, GETDATE()), 25000, DATEADD(DAY, -15, GETDATE())),
(103, 3, 'Headphones', DATEADD(DAY, -100, GETDATE()), 3000, DATEADD(DAY, -100, GETDATE()));

SELECT 
    o.OrderID, 
    c.Name AS CustomerName, 
    o.Product, 
    o.OrderDate
FROM 
    Orders o
JOIN 
    Customers c ON o.CustomerID = c.CustomerID
WHERE 
    o.OrderDate >= DATEADD(day, -7, GETDATE())
      AND o.OrderDate < GETDATE();


CREATE TABLE Subscriptions (
    SubscriptionID INT PRIMARY KEY,
    CustomerID INT,
    SubscriptionEndDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

INSERT INTO Subscriptions VALUES
(201, 1, DATEADD(DAY, 5, GETDATE())),
(202, 2, DATEADD(DAY, 10, GETDATE())),
(203, 3, DATEADD(DAY, 2, GETDATE()));

SELECT 
    c.Name AS CustomerName, 
    c.Email,
    s.SubscriptionEndDate
FROM 
    Subscriptions s
JOIN 
    Customers c ON s.CustomerID = c.CustomerID
WHERE 
    s.SubscriptionEndDate = DATEADD(day, 5, CAST(GETDATE() AS DATE));


CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(50),
    JoiningDate DATE
);

INSERT INTO Employees VALUES
(301, 'Suresh', '2018-01-04'),
(302, 'Anitha', '2020-07-20'),
(303, 'Vishnu', '2019-03-12');

SELECT 
    Name, 
    JoiningDate
FROM 
    Employees
WHERE 
    FORMAT(JoiningDate, 'MM-dd') =  FORMAT(GETDATE(), 'MM-dd');


CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY,
    ProjectName VARCHAR(50),
    DeadlineDate DATE
);
SELECT 
    p.ProjectName, 
    p.DeadlineDate, 
    DATEDIFF(day, p.DeadlineDate, GETDATE()) AS DaysOverdue
FROM 
    Projects p
WHERE 
    p.DeadlineDate < GETDATE();



INSERT INTO Projects VALUES
(401, 'Website Revamp', DATEADD(DAY, -5, GETDATE())),
(402, 'Mobile App', DATEADD(DAY, 10, GETDATE())),
(403, 'CRM System', DATEADD(DAY, -20, GETDATE()));

CREATE TABLE Members (
    MemberID INT PRIMARY KEY,
    Name VARCHAR(50),
    MembershipStartDate DATE
);
INSERT INTO Members VALUES
(501, 'Akhil', DATEADD(DAY, -200, GETDATE())),
(502, 'Neha', DATEADD(DAY, -120, GETDATE())),
(503, 'Ravi', DATEADD(DAY, -30, GETDATE()));


SELECT c.Name, MAX(o.LastOrderDate) AS LastOrderDate,
DATEDIFF(DAY, MAX(o.LastOrderDate), GETDATE()) AS InactiveDays
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
GROUP BY c.Name
HAVING DATEDIFF(DAY, MAX(o.LastOrderDate), GETDATE()) > 90;

SELECT MONTH(OrderDate) AS Month, SUM(Amount) AS TotalSales
FROM Orders
WHERE YEAR(OrderDate) = YEAR(GETDATE())
GROUP BY MONTH(OrderDate);


SELECT Name, Email, BirthDate
FROM Customers
WHERE FORMAT(BirthDate, 'MM-dd') = FORMAT(GETDATE(), 'MM-dd');


SELECT OrderID, OrderDate,
DATEADD(DAY, 10, OrderDate) AS DeliveryDate
FROM Orders;

SELECT Name, MembershipStartDate,
DATEDIFF(DAY, MembershipStartDate, GETDATE()) AS ActiveDays
FROM Members;



CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    LaunchDate DATE
);

INSERT INTO Products VALUES
(601, 'Smart Watch', GETDATE()),
(602, 'Gaming Mouse', DATEADD(MONTH, -1, GETDATE())),
(603, 'Bluetooth Speaker', DATEADD(MONTH, -4, GETDATE()));

SELECT ProductName, LaunchDate
FROM Products
WHERE DATEPART(QUARTER, LaunchDate) = DATEPART(QUARTER, GETDATE())
AND YEAR(LaunchDate) = YEAR(GETDATE());
