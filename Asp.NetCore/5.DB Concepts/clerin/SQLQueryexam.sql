create database Examination

create table Customer(CustomerID int primary key,CustomerName varchar(100),City varchar(50));


insert into Customer values(1,'Alice','New York'),(2,'Bob','Chicago'),(3,'charlie','Los Angeles'),
(4,'David','Houston');
insert into Customer values(5,'vishnu','Thrissur'),(6,'Edwin','palakkad'),(7,'junaidh','Kochi');



create table Orders(OrderID int primary key,CustomerID int,foreign key(CustomerID) references Customer
(CustomerID),OrderDate Date,TotalAmount decimal(10,2));


insert into Orders  values(101,1,'2024-02-15',500),(102,2,'2024-02-16',700),(103,1,'2024-03-01',200),
(104,3,'2024-03-05',900),(105,2,'2024-03-07',450);

select * from Customer;
select * from Orders;


select TotalAmount,SUM(TotalAmount) 
from Customer
where TotalAmount>100;



select SUM(TotalAmount) as TotalAmount
from Orders
Where(TotalAmount)>100;




SELECT COUNT(*) 
FROM Orders
WHERE OrderDate >= '2024-03-01'
  AND OrderDate <= '2024-04-01';



  select MAX(TotalAmount) from Orders;