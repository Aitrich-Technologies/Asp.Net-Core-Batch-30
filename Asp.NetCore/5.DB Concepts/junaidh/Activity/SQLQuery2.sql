create database Online

create table restaurant(
reataurantId int primary key,Name varchar(20)NOT NULL,location varchar(50),Rating decimal(10,2)
);
select * from restaurant

create table Customers(
customerId int primary key,FullName varchar(60),Email varchar(50)not null,PhoneNumber varchar(15)
);

create table Orders(
OrderId int primary key,CustomerId int,RestaurantId int,orderDate DATE,totalamount int)

alter table Orders
Add DeliveryAddress varchar(20);
alter table restaurant alter column rating float
alter table orders add ordstatus varchar(30)
exec sp_rename Customers, Clients
alter table restaurant drop column rating
select * from restaurant

insert into restaurant values(1,'meenology','puzhakal')
insert into restaurant values(2,'TZONE','poonkunnam')
insert into restaurant values(3,'KAIZ kiTCHEN','Railways')
select * from  restaurant



insert into Clients values(1,'Edwin','edwin@123',1234567890)
insert into Clients values(2,'Vishnu','vishnu@234',0987654321)
insert into Clients values(3,'Joyal','Joyal@546',9087654321)
select * from Clients

insert into Orders values(1,2,3,'12-12-2025',500,'thrissur','success')
insert into Orders values(2,1,2,'10-10-2025',1000,'ernakulam','pending')
insert into Orders values(3,3,1,'11-12-2025',1500,'thiruvananthapuram','pending')

select * from Orders

select FullName,PhoneNumber from Clients
select Fullname,PhoneNumber from Clients where FullName = 'Joyal'
select FullName,Email from Clients where customerId = 1

ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_Clients
FOREIGN KEY (CustomerId)
REFERENCES Clients(CustomerId);
select * from Orders

ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_restaurant
FOREIGN KEY (reataurantId)
REFERENCES restaurant(reataurantId);
 
select *  from orders




