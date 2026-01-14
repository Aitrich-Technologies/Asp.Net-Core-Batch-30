create database mathfunction

create table Orders(OrderID int primary key,TotalAmount decimal(10,2),DiscountPercentage bigint,Quantity int)

insert into Orders values(1,100.00,10,2),(2,250,15,1),(3,350,5,3)

select OrderID,DiscountPercentage,ABS(DiscountPercentage)as CorrectedDiscountPercentage from Orders 

select OrderID,TotalAmount,DiscountPercentage,Round(totalAmount*(1-DiscountPercentage/100),2) as finalamount from Orders

select OrderID,TotalAmount, Ceiling(TotalAmount *(1-DiscountPercentage/100)) as RoundedUpAmount from Orders

select OrderID,TotalAmount,Floor(TotalAmount *(1-DiscountPercentage/100)) as RoundedDownAmount From Orders;

select OrderID,TotalAmount,Power(TotalAmount,2) as LoyaltyPoints from Orders

select OrderID,TotalAmount,SQRT(TotalAmount) as CustomerLoyaltyScore from Orders