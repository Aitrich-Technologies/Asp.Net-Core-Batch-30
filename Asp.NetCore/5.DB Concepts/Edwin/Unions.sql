create database Unions;

create table Employees_A(empid int identity(100,101),name varchar(50))
create table Employees_B(empid int identity(1,1), name varchar(50),salary decimal(10,2))
insert into Employees_A values('Vishnu'),('Aswin'),('Joyal');
insert into Employees_B values('Joyal',50000),('Edwin',45000),('Naven',80000);
select * from Employees_A
select * from Employees_B
select name from Employees_A
union
select name from Employees_B

select name from Employees_A
Union all
select name from Employees_B

select name from Employees_A
union 
select salary from Employees_B

select name,salary from Employees_B
union all
select name,null from Employees_A

select name from Employees_A
union all
select CAST( salary as varchar(30)) from Employees_B

create table Sales(salesid int ,Amount decimal(10,2))
create table Sales_B(salesid int , Products varchar(50),Amount decimal(10,2))
insert into Sales values(1,200),(2,400),(3,600),(4,800);
insert into Sales_B values(2,'Silver',200),(4,'Drinks',500),(6,'snaks',800);

select * from Sales
select * from Sales_B



select salesid,Amount from Sales
union all
select salesid,Amount from Sales_B

select salesid,Amount from Sales
union 
select salesid, Amount from Sales_B

create table Employes(employeeid int identity(1,1) ,name varchar(80),Departmenid bigint)
create table Departments(Departmentid int identity(1,1),DepartmentName varchar(80));
insert into Employes values('Alice',1),('Bob',2),('Charlie',3);
insert into Departments values('HR'),('IT'),('Finance');
insert into Employes (name) values('David');
insert into Departments (DepartmentName) values('Accounting');

SELECT Employes.name, Departments.DepartmentName
FROM Employes
INNER JOIN Departments ON Employes.Departmenid = Departments.Departmentid;

select Employes.name,Departments.DepartmentName
from Employes
Left join Departments on Employes.Departmenid=Departments.Departmentid;

select Employes.name,Departments.DepartmentName
from Employes
Right join Departments on Employes.Departmenid=Departments.Departmentid;

select Employes.name,Departments.DepartmentName
from Employes
Full join Departments on Employes.Departmenid=Departments.Departmentid;

select Employes.name, Departments.DepartmentName
from Employes
CROSS JOIN Departments;

create table Employeess(Employeeid int identity(1,1),name varchar(50),ManagerId bigint)
insert into Employeess values('Alice',Null),('Bob',1),('Charlie',1);
select e.name as employee,m.name as Manager
from Employeess e
Left JOIN Employeess m on e.ManagerId=m.Employeeid;


create table customer(customerid int identity(1,1),Name varchar(50))
create table Orders(orderid int identity(1,1),customerid bigint,Amount decimal(10,2))
insert into customer values('Alice'),('Bob'),('Charlie');
insert into  Orders values(1,500),(2,300);

select Name From customer where Exists(select 1 from Orders where Orders.customerid=customer.customerid);