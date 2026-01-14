create database AggregFunction

CREATE TABLE Sales (
    SaleID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Quantity INT,
    PricePerUnit DECIMAL(10,2),
    SaleDate DATE
);

INSERT INTO Sales VALUES
(1, 'Laptop', 'Electronics', 2, 1000.00, '2025-01-10'),
(2, 'Smartphone', 'Electronics', 3, 800.00, '2025-01-12'),
(3, 'Bread', 'Groceries', 5, 2.50, '2025-01-13'),
(4, 'Milk', 'Groceries', 10, 1.50, '2025-01-14');

select avg(PricePerUnit) as  AverageSalesPrice
from Sales;

select sum(quantity * PricePerUnit) as TotalRevenue
from Sales;

select count(*) as TotalNumberOfSales 
from Sales;

select max(PricePerUnit) as MaximPricePerUnit
from Sales;

select min(PricePerUnit) as MinimPricePerUnit
from Sales

