create database UDFs

create table Orders(
OrderID int identity(1,1),
CustomerID int primary key,
PurchaseAmount decimal(10,2),
OrderDate date 
);

insert into Orders values (101,120,'2025-01-01'),(102,540,'2025-01-02'),(103,30,'2025-01-03'),(104,600,'2025-01-04'),(105,480,'2025-01-05');
select * from Orders

create function CalculateLoyaltyPoints(@PurchaseAmount decimal(10,2))
returns int
as
begin
declare @Points int;
declare @Bonus int;

set @Points = FLOOR(@PurchaseAmount/10);
if @PurchaseAmount >500
begin
set @Bonus = FLOOR(@Points * 0.1);
set @Points = @Points + @Bonus;
end
return @Points;
end

select  CustomerID,PurchaseAmount,
dbo.CalculateLoyaltyPoints(PurchaseAmount) as LoyaltyPoints
from Orders




create function GetLoyaltyPoints(@MinPurchaseAmount decimal(10,2))
returns @CustomersPoints table
(
CustomerID int ,
PurchaseAmount decimal(10,2),
LoyaltyPoints int 
)
as
begin 
insert into @CustomersPoints
select CustomerID,PurchaseAmount,
dbo.CalculateLoyaltyPoints(PurchaseAmount) as LoyaltyPoints
from Orders where PurchaseAmount >= @MinPurchaseAmount;
return;
end;

select * from dbo.GetLoyaltyPoints(100);