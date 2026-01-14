create database Mathfunction

create table Sales(
OrderID int identity(1,1) primary key,
TotalAmount decimal(10,2),
DiscountPercentage bigint,
Quantity int
);

insert into Sales values(100,10,2),(250,15,1),(350,5,3);
select * from Sales

select OrderID,DiscountPercentage,
ABS(DiscountPercentage) as CorrectedDiscountPercentage
from Sales


select OrderID,TotalAmount,DiscountPercentage,ROUND(TotalAmount * (1-DiscountPercentage / 100),2)as FinalAmount
from Sales


select OrderID,TotalAmount,CEILING(TotalAmount * (1-DiscountPercentage / 100)) as RoundedUpAmount
from Sales


select OrderID,TotalAmount,FLOOR(TotalAmount *(1-DiscountPercentage / 100)) as RoundedDownAmount
from Sales


select OrderID,TotalAmount,POWER(TotalAmount,2) as LoyaltyPoints
from Sales

select OrderID,TotalAmount,SQRT(TotalAmount)as CustomerLoyaltyScore
from Sales


