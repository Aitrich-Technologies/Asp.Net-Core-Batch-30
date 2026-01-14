create database sales

create table Sale(SaleID int identity(1,1),ProductName varchar(100),Category varchar(100),Quantity int,PricePerUnit decimal(10,2),SaleDate date)


insert into Sale values( 'Laptop', 'Electronics', 2, 1000.00, '2025-01-10'),
( 'Smartphone', 'Electronics', 3, 800.00, '2025-01-12'),
( 'Bread', 'Groceries', 5, 2.50, '2025-01-13'),
( 'Milk', 'Groceries', 10, 1.50, '2025-01-14');

select avg(PricePerUnit) as AveragesSalePrice from Sale;

select sum(Quantity * PricePerUnit) as TotalRevenue from Sale;

select Count(*) as TotalSales from Sale;

Select Max(PricePerUnit) as MaxPricePerUnit from Sale;

select Min(PricePerUnit) as MinPricePerUnit from Sale;


