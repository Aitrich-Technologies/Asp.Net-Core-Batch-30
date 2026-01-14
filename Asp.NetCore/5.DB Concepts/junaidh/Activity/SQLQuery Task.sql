create database task;

create table Employees(
EmployeeId int primary key,
Name varchar(100),
Department varchar(50),
Salary decimal(10,2)
);
select * from  Employees

insert into Employees values(1,'junaidh','developer',50000),
(2,'edwin','developer',50000),
(3,'vishnu','S.E',60000),
(4,'joyal','developer',50000),
(5,'clerin','developer',50000),
(6,'prinitta','S.E',60000);

select Department,count(EmployeeId) as totalemp from Employees
where Salary >=50000
group by Department
having count(EmployeeId) >=4



create table Students(
Id int identity(1,1)primary key,
Name varchar(100),
Course varchar(50),
Marks int 
);
select * from Students

insert into Students values('john','EEE',80),('Rock','ECE',75),('hulk','CSE',69),('Neymar','CSE',89),('Bale','CIVIL',97);

select Course,AVG(Marks) as AVGmarks from Students
where Marks>=40  group by Course having AVG(Marks)>=75;



create table Sales(
SaleID int primary key,
Category varchar(50),
SalesAmount decimal(10,2),
OrderDate datetime default getdate()
);

select * from Sales
insert into Sales values(11,'Fish',90000,getdate()),(22,'Meat',120000,GETDATE()),(33,'pork',100000,GETDATE()),(44,'Chicken',110000,GETDATE());

select Category,sum(SalesAmount) as TotalSales from Sales group by Category 
having sum(SalesAmount)>=100000;



create table Customers(
CustomerID int identity(1,1) primary key,
Name varchar(100),
City varchar(100),
Country varchar(100)
);
select * from Customers
insert into Customers values ('Rahul','new york','USA'),
 ('Ravi','new york','USA'),
  ('kishore','new york','USA'),
   ('Reenu','new york','USA'),
    ('amal','Barcelona','Spain'),
     ('george','new york','USA'),
      ('peter','Rosario','Argentina'),
       ('messi','new york','USA'),
        ('lohit','Madeira','Portugal'),
         ('hari','new york','USA'),
          ('john','pune','India'),
           ('yadhu','new york','USA'),
            ('ashwin','pune','India'),
             ('vishak','new york','USA'),
              ('rafi','new york','USA');

SELECT City,COUNT(CustomerID) AS TotalCustomers
FROM Customers
WHERE Country = 'USA'
GROUP BY City
HAVING COUNT(CustomerID) >= 1;



create table Projects(
PID int primary key,
EID int identity(1,1),
HoursWorked int ,
Status varchar(100));
select * from Projects

insert into Projects values(101,600,'completed'),(102,400,'ongoing'),(103,500,'ongoing'),(104,540,'completed'),(105,610,'completed'),
(106,550,'completed'),(107,470,'ongoing');

select PID , sum(HoursWorked) as Totalhours
from Projects where Status = 'completed'
group by PID  having sum(HoursWorked)>=500;


