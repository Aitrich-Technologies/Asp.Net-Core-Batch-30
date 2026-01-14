create database SQLAssesment

create table Customers(
CustomerID int primary key,
CustomerName varchar(50),
City varchar(50)
);

insert into Customers values(1,'Alice','New York'),(2,'Bob','Chicago'),(3,'Charlie','Los Angeles'),(4,'David','Houston');

select * from Customers

create table Orders(
OrderID int identity(100,101),
CustomerID int foreign key(CustomerID) references Customers(CustomerID),
OrderDate date ,
TotalAmount decimal(10,2)
);

insert into Orders values(1,'2024-02-15',500),(2,'2024-02-16',700),(1,'2024-03-01',200),(3,'2024-03-05',900),(2,'2024-03-07',450);

select * from Orders

select sum(TotalAmount)as totalAmount from Orders group by CustomerID 


select max(TotalAmount) as highestAmount
from Orders 

select count(*) as MrchOrders from Orders where OrderDate >= '2024-03-01' and OrderDate < '2024-04-01'


select CustomerID,count(*)as recentOrders from Orders group by CustomerID  

select min(CustomerID) as zeroOrders from Orders 

