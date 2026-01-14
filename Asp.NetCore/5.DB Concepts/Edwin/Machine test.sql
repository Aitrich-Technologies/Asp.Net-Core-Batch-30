create database Customers

create table customers(CustomerID int primary key,CustomerName varchar(100),City varchar(100))

insert into customers values(1,'Alice','New York'),(2,'Bob','chicago'),(3,'Charlie','Los Angeles')
select* from customers

create table Orders(OrderID int primary key,Customerid int,OrderDate Date,TotalAmount decimal(10,2), foreign key(Customerid) references customers(CustomerID))

insert into Orders values(101,1,'2024-02-15',500),(102,2,'2024-02-16',700),(103,1,'2024-03-01',200),(104,3,'2024-03-05',900),(105,2,'2024-03-07',450)

select * from Orders



select sum(TotalAmount) as TotalAmount
from Orders group by CustomerID



select count(*) as NeverpalcedOrders
from customers where CustomerID=4






select count(*) as Orders
from Orders where  OrderDate >='2024-03-01' And OrderDate <'2024-04-01';




select CustomerID, Count(*) as MostRecentOrder
from Orders group by CustomerID

select max(TotalAmount)as highestAmount
from Orders
