create database T_SQL_Workshop

create table Company(
CompanyID int primary key not null,
Name varchar(100),
Remarks varchar(250)
);

create proc Company_Insert
(
@v_name as varchar(100),
@v_remarks as varchar(250)
)
as
declare @v_id as  int

begin
select @v_id = (select isnull(max(CompanyID),0)+1 from Company)
insert into Company values(@v_id,@v_name,@v_remarks)
end 
go

EXEC Company_Insert 'aitrich','good'
exec Company_Insert 'wipro','good'
exec Company_Insert 'Infosys',''


create Proc Company_Update
(
@v_id as int ,
@v_name as varchar(100),
@v_remarks as varchar(250)
)
as
begin
update Company set Name = @v_name,Remarks = @v_remarks where CompanyID = @v_id
end 
go

exec Company_Update 1,'Aitrich technologies','very Good'
select * from Company

create proc Company_delete
(
@v_id as int
)
as
begin
delete from  Company where CompanyID = @v_id
end
go

exec Company_delete 1


CREATE PROC deleteProc
(
    @v_tname varchar(50),
    @v_id int 
)
AS
BEGIN
    DECLARE @sql varchar(200)

    SET @sql = 'DELETE FROM ' + @v_tname +' WHERE CompanyID = ' + CONVERT(varchar(10), @v_id)

    EXEC (@sql)
END
GO
exec deleteProc 'Company',2

create proc selectproc
(
@v_name varchar(50)
)
as 
begin
exec ('select * from Company where name = '''+@v_name + '''')
end 
go

EXEC selectproc 'Infosys'


CREATE PROC selectproc1
(
    @v_condition VARCHAR(200)
)
AS
BEGIN
    EXEC('SELECT * FROM Company ' + @v_condition)
END
GO

EXEC selectproc1 'WHERE name = ''Infosys'''


create proc selectproc2
(
@v_tname varchar(50) = null
) 
as
begin
exec('select * from Company' + @v_tname)
end
go
exec selectproc2

create proc selectproc3
as 
begin
exec selectproc2
end 
go


--UserDefinedFunctions
create function dbo.company_id()
returns bigint
as 
begin
declare @company_id AS bigint
select @company_id = (select ISNULL(max(@company_id),0)+1 from Company)
return (@company_id)
end

select dbo.company_id()


create function dbo.Get_Fullname
(
@field1 varchar(50),
@field2 varchar(50)
)
returns varchar(100)
begin
return (@field1 +','+@field2)
end
go

select dbo.Get_Fullname(name,remarks)as Full_name from Company


create function dbo.GetTable
(
@Name varchar(30)
)
returns table
as
return select * from Company where name =@Name
go

select * from dbo.GetTable('Infosys')


create table Purchase(
ID varchar(25) primary key,
Item_id int ,
Quantity int,
amount decimal(10,2)
);

insert into Purchase values('1',101,3,2000),('2',102,5,1500),('3',103,4,2500),('4',104,2,2000);
select * from Purchase

CREATE FUNCTION dbo.get_purchasecode() 
	 RETURNS varchar(50) 
	AS  
	BEGIN 

	DECLARE @purchase_code as varchar(50)
	
SELECT @purchase_code =(SELECT 'PU' + LEFT('00000000',8-LEN(LTRIM(STR(RIGHT(MAX(id),8)+1))))+ LTRIM(STR(RIGHT(MAX(id),8)+1))   FROM  Purchase) 
		
	RETURN ISNULL(@purchase_code,'PU'+'00000001')
	END

select dbo.get_purchasecode()



--TRIGGERS
CREATE TABLE Purchases (
    id INT PRIMARY KEY,
    item_id INT NOT NULL,
    quantity INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL
);

INSERT INTO Purchases 
VALUES
(1, 101, 10, 5000),
(2, 102, 5, 2500),
(3, 104, 8, 4000);  


CREATE TABLE Stock (
    id INT  PRIMARY KEY,
    item_id INT NOT NULL UNIQUE,
    quantity INT NOT NULL
);

INSERT INTO Stock 
VALUES
(1, 101, 50),
(2, 102, 30),
(3, 103, 40);



CREATE TABLE Sales (
    id INT  PRIMARY KEY,
    item_id INT NOT NULL,
    quantity INT NOT NULL,
    amount DECIMAL(10,2) NOT NULL
);

INSERT INTO Sales 
VALUES
(1, 101, 6, 3000),
(2, 102, 4, 2000);
select * from Sales
Create trigger [add_stock] on [dbo].[Purchase] for insert
as
begin
	declare @qty as float,@item_no as bigint,@id as bigint,@stock as float
	select @qty=(select quantity from inserted)
	select @item_no=(select item_id from inserted)
	set @stock=(select count(*) from stock where item_id=@item_no)
	if(@stock>0)
		begin
			update stock set quantity=quantity+@qty where item_id=@item_no
		end
	else
		begin
			set @id=(select isnull(max(id),0)+1 from stock)
			insert into stock values(@id,@item_no,@qty)
		end
end


Create trigger [less_stock] on [dbo].[Sales] for insert
as
begin
	declare @qty as float,@item_no as bigint,@id as bigint,@stock as float
	select @qty=(select quantity from inserted)
	select @item_no=(select item_id from inserted)
	set @stock=(select count(*) from stock where item_id=@item_no)
	if(@stock>0)
		begin
			update stock set quantity=quantity-@qty where item_id=@item_no
		end
	else
		begin
			set @id=(select isnull(max(id),0)+1 from stock)
			insert into stock values(@id,@item_no,@qty)
		end
end


select * from Stock
select * from Sales
select * from Purchases

