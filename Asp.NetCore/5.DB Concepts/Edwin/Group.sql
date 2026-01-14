create database Groups;
create table  students(Studentid  int identity(1,1),Studentsname varchar(100),Coursename varchar(50),Marks int)
insert into students values('Aswin','B.C.A',66),('Vishnu','B.sc',77),('Naveen','Maths',89),('Benlin','IT',100)
select * from students
select Coursename, Avg(Marks) as Averagemarks from students group by Coursename;

select * from students
select Coursename, Avg(Marks) as Averagemarks from students where Marks>=40 group by Coursename;
select Coursename, Avg(Marks) as Averagemarks from students group by Coursename  having avg(Marks)>75;
select * from students;

create table Sales(Saleid int identity(1,1), Category varchar(60), SalesAmount decimal(10,2),Orderdate Date)
insert into Sales values('Drinks',25,getdate()),('Snaks',20,getdate()),('Soap',10,getdate()),('pen', 5,getdate());
insert into Sales values('gold',200000,getdate()),('silver',100000,getdate());
select * from Sales;
select Category, sum(SalesAmount) as totalsales from Sales where OrderDate >= '2025-01-01' group by Category having sum(SalesAmount)>=100000; 




Create table Customers(id int identity(1,1),name varchar(100),city varchar(100),country varchar(50))
insert into Customers values('Edwin','Thrissur','India'),('Aswin','Palakkad','India'),('Naveen','sheffield','London');
select City, count(id) as TotalCustomers from Customers where Country = 'London' group by City having count(id) >=1;
select * from Customers;

create table Projects(proid int identity(1,1),empid bigint ,hourseworked int, status varchar(20));
insert into Projects values(100,60,'completed'),(101,50,'completed'),(102,100,'pending'),(103,80,'pending'),(104,85,'completed'),(105,100,'pending'),(106,89,'pending');
insert into Projects values(107,620,'completed');
select proid,sum(hourseworked) as totalHourse from Projects where status ='Completed' group by proid having sum(hourseworked)>=500;
select * from Projects;


