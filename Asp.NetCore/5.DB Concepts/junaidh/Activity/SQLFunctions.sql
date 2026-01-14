create database functionss

create table Customers(
CustomerID int primary key,
CustomerName varchar(666)
);

INSERT INTO Customers VALUES
(1, 'John Doe'),
(2, 'Jane Smith'),
(3, 'Michael Brown'),
(4, 'Emily Davis');


create table Products(
ProductID int primary key,
ProductName varchar(444),
Price decimal(10,2)
);

INSERT INTO Products VALUES
(1, 'Laptop', 1000),
(2, 'Smartphone', 500),
(3, 'Tablet', 300),
(4, 'Headphones', 100);


CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    ProductID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Orders VALUES
(101, 1, '2023-01-10', 1),
(102, 3, '2023-02-15', 2),
(103, 4, '2023-03-05', 3),
(104, 1, '2023-04-12', 2);


SELECT CustomerID, COUNT(OrderID) AS OrderCount
FROM Orders
GROUP BY CustomerID;

SELECT SUM(Products.Price) AS TotalRevenue
FROM Orders
INNER JOIN Products ON Orders.ProductID = Products.ProductID;

SELECT AVG(Products.Price) AS AveragePrice
FROM Orders
INNER JOIN Products ON Orders.ProductID = Products.ProductID;


SELECT MIN(Price) AS LowestPrice
FROM Products;

SELECT MAX(Price) AS HighestPrice
FROM Products;

SELECT COUNT(DISTINCT CustomerID) AS UniqueCustomers
FROM Orders;

SELECT Products.ProductName, SUM(Products.Price) AS TotalRevenue
FROM Orders
INNER JOIN Products ON Orders.ProductID = Products.ProductID
GROUP BY Products.ProductName;

SELECT Customers.CustomerName, AVG(Products.Price) AS AverageSpent
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID
INNER JOIN Products ON Orders.ProductID = Products.ProductID
GROUP BY Customers.CustomerName;



SELECT ProductID, COUNT(OrderID) AS OrderCount
FROM Orders
GROUP BY ProductID
HAVING COUNT(OrderID) > 1;


SELECT Customers.CustomerName, SUM(Products.Price) AS TotalSpent, AVG(Products.Price) AS AverageOrderValue
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID
INNER JOIN Products ON Orders.ProductID = Products.ProductID
GROUP BY Customers.CustomerName;

