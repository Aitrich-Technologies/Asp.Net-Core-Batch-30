create table Restaurant(RestaurantID int primary key, name varchar(20),Location int, rating int)
create table Customers(	CustomerID int, fullname varchar(20), email varchar(200),phonenumber varchar(10))
create table orders(orderid int,CustomerID int,RestaurantID  int, orderdate date,totalamount int)

Alter table orders
Add DeliveryAddress  varchar(20);
alter table Restaurants alter column rating float
alter table orders add ordstatus varchar(30)
exec sp_rename Customers ,Clients
alter table Restaurant drop column rating
select * from Restaurant

drop table Restaurants
insert  into Clients values(1,'vishnu cm', 'vishnucm@gmail.com',1234567890)
insert  into Clients values(2,'joyal pm', 'joyalpm@gmail.com',1234567880)
insert  into Clients values(1,'junaidh p', 'junaidhp@gmail.com',1234567870)

insert into Restaurant values(3,'MC','111111')

insert into orders values(9,2,3,'12-12-2025',1000,'kunnamkulam','pending')
select * from Clients
select fullname, email from Clients
select fullname,email from Clients where CustomerID=1

ALTER TABLE orders ADD CONSTRAINT Restaurant FOREIGN KEY (CustomerID) REFERENCES Client(RestaurantID);
select * from orders
