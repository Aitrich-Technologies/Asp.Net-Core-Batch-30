create database customer

create table Customers(CustomerID int identity(1,1) primary key,CustomerName varchar(100))
create table Orders(OrderID int identity(1,1) primary key, CustomerID int ,Orderdate date , ProductID int, FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)) 
create table Products(ProductID int identity(1,1) primary key,ProductName varchar(100),Price decimal(10,2))

insert into Customers values('John Doe'),('Jane Smith'),('Michael Brown'),('Emily Davis')
insert into Products values('Laptop',70000),('SmartPhone',25000),('Tablet',10000),('HeadPhones',2500)
insert into Orders values(1,'2023-01-10',1),(3,'2023-02-15',2),(4,'2023-03-05',3),(1,'2023-04-12',2)
select * from Orders
Select CustomerID, count(OrderID) as OrderCount from Orders group by CustomerID
select sum(Products.Price) as TotalRevenue from Orders inner join Products on Orders.ProductID = Products.ProductID
select avg(Products.Price) as AveragePrice from Orders inner join Products on Orders.ProductID = Products.ProductID
select min(Price) as LowestPrice from Products
select Max(Price) as HighestPrice from Products

select Count(Distinct CustomerID) as UniqueCustomers from Orders
select Products.ProductName, sum(Products.Price) as TotalRevenue from Orders
inner join Products on Orders.ProductID=Products.ProductID group by Products.ProductName

Select Customers.CustomerName, avg(Products.Price) as AverageSpent from Orders Inner join Customers on Orders.CustomerID = Customers.CustomerID
inner join Products on Orders.ProductID= Products.ProductID group by Customers.CustomerName

select ProductID, count(OrderID) as OrderCount from Orders group by ProductID having COUNT(OrderID) > 1

select Customers.CustomerName, sum(Products.Price) as TotalSpent, avg(Products.Price) as AverageOrderValue from Orders inner join Customers on Orders.CustomerID = Customers.CustomerID
inner join  Products on  Orders.ProductID = Products.ProductID group by Customers.CustomerName