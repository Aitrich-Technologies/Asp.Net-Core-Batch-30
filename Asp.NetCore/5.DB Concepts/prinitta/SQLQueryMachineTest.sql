create database Machinetest

create table Customer(CustomerId int primary key, CustomerName varchar(100) not null, City varchar(50))

insert into Customer values(1,'Alice','NewYork'),(2,'Bob','Chicago'),(3,'Charlie', 'Los Angeles'),(4,'David','Houston');

create table Orders(OrderId int primary key,CustomerId int foreign key(CustomerId) references Customer(CustomerId), OrderDate Date, TotalAmount Decimal(10,2));

insert into Orders values(101,1,'2024-02-15',500),(102,2,'2024-02-16',700),(103,1,'2024-03-01',200),(104,3,'2024-03-05',900),(105,2,'2024-03-07',450);

select * from Customer;
select * from Orders;

select MAX(TotalAmount) as HighestAmount from orders;

select count(*) AS orders
from Orders
where OrderDate >= '2024-03-01'
AND OrderDate < '2024-04-01';

select SUM(TotalAmount)
as TotalAmount from orders where(TotalAmount)>100

