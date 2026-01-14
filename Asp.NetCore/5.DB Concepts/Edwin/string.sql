create database String

create table Customers(CustomerID int identity(1,1),FirstName varchar(50),LastName varchar(50),Email varchar(100),Username varchar(50))

insert into Customers values('John', 'Doe','john.doe@gmail.com','john  doe '),(	'Alice', 'Smith','alice.smith@yahoo.com','alice Wonderland'),('Bob','Brown','bob.brown@hotmail.com','Millie	bobby')

select Upper(FirstName) as FirstName, Upper(LastName) as LastName from Customers

select Concat(FirstName,' ',LastName) as FullName from Customers

select SUBSTRING(Username,5,8) as initials from Customers
select Len (Email) as EmailLength from Customers
select trim(Username) as CleanUsername from Customers