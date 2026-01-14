create database strngFunction

create table Customers(
CustomerID int identity(1,1),
FirstName varchar(444),
LastName varchar(555),
Email varchar(444),
UserName varchar(111)
);


insert into Customers values('John','Doe','john.doe@gmail.com',' john doe '),
('Alice','Smith','alice.smith@yahoo.com',' Alice smith '),
('Bob','Brown','bob.brown@hotmail.com',' bobby ');

select upper(FirstName) as firstname,upper(LastName) as lastname
from Customers

select concat(Firstname,' ',LastName) as FullName
from Customers


select substring(UserName,4,9) as initials
from Customers


select len(Email) as EmailLength
from Customers


select trim(UserName) as cleanUsername
from Customers


