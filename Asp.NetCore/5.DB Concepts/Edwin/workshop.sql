create database Company

create table Companies(Company_id int primary key,Name varchar(100),Remarks varchar(250))

insert into Companies values(1, 'infosys','Good'),(2,'TCS','Good'),(3,'IBM','Perfect'),(4,'Luminar','Bad')

CREATE PROC Company_Insert
(
    @v_name VARCHAR(100),
    @v_remarks VARCHAR(250)
)
AS
BEGIN
    DECLARE @v_id INT;

    SELECT @v_id = ISNULL(MAX(Company_id), 0) + 1
    FROM Companies;

    INSERT INTO Companies(Company_id, Name, Remarks)
    VALUES (@v_id, @v_name, @v_remarks);
END;
GO



EXEC Company_Insert 'infosys', 'Good';
EXEC Company_Insert 'TCS', 'Good';
EXEC Company_Insert 'IBM', 'Perfect';

CREATE PROC Company_Update
(
    @v_id INT,
    @v_name VARCHAR(100),
    @v_remarks VARCHAR(250)
)
AS
BEGIN
    UPDATE Companies
    SET name = @v_name,
        remarks = @v_remarks
    WHERE company_id = @v_id
END
GO

EXEC Company_Update 2,'TCS','Good'

create Proc Company_Delete
(
@v_id as int
)
as
begin
delete from Companies where Company_id=@v_id
end
Go
EXEC Company_Delete 1
drop Proc deleteProc

CREATE PROC deleteProc
(
    @v_tname VARCHAR(50),
    @v_id INT 
)
AS
BEGIN
    DECLARE @sql VARCHAR(200)

    SET @sql = 
        'DELETE FROM ' + @v_tname +
        ' WHERE Company_id = ' + CONVERT(VARCHAR(10), @v_id)

    EXEC (@sql)
END
GO
EXEC deleteProc 'Companies',5


select * from Companies

drop proc SelectProc
CREATE PROC SelectProc
(
    @v_name VARCHAR(50)
)
AS
BEGIN
    EXEC (
        'SELECT * FROM dbo.Companies WHERE name = ''' + @v_name + ''''
    )
END
GO


EXEC SelectProc 'TCS'

drop proc selectProc1

CREATE PROC selectProc1
(
    @v_tname VARCHAR(100)
)
AS
BEGIN
    EXEC (
        'SELECT * FROM dbo.Companies ' + @v_tname
    )
END
GO

EXEC selectProc1 'WHERE Company_id = 3'

EXEC selectProc1 'WHERE name = ''IBM'''

EXEC selectProc1 'WHERE remarks = '''' AND Company_id = 3'

CREATE PROC dbo.SelectProc2
(
    @v_tname VARCHAR(50) = NULL
)
AS
BEGIN
    DECLARE @sql VARCHAR(200)

    SET @sql = 
        'SELECT * FROM dbo.Companies ' + ISNULL(@v_tname, '')

    EXEC (@sql)
END
GO


EXEC dbo.SelectProc2
EXEC dbo.SelectProc2 'WHERE Company_id = 3'
EXEC dbo.SelectProc2 'WHERE name = ''IBM'''

create function dbo.company_id()
returns bigint
as 
begin
declare @company_id as bigint
select @company_id=(select isnull(max(Company_id),0)+1 from Companies)
return (@company_id)
END
select dbo.company_id()

create function dbo.get_fullname
(
@field1 varchar(50),
@field2 varchar(50)
)
returns varchar(100)
begin
return (@field1 +','+@field2)
END
GO
select dbo.get_fullname(name,remarks) as full_name from Companies

CREATE FUNCTION dbo.gettable
(
    @name VARCHAR(30)
)
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM dbo.Companies
    WHERE name = @name
)
GO


create table Purchase(Id int primary key ,item_id int,quantity int,amount decimal(10,2))

insert into Purchase values(1,100,2,200),(2,101,3,300),(3,102,1,100)

create function dbo.get_purchasecode()
returns varchar(50)
as
begin
declare @purchase_code as varchar(50)
select @purchase_code=(select 'PU' + left('00000000',8-len(LTRIM(str(right(max(id),8)+1))))+LTRIM(str(right(max(id),8)+1)) from Purchase)
return isnull(@purchase_code,'PU'+'00000001')
END

select dbo.get_purchasecode()

create table Purchases(Id int primary key ,item_id int,quantity int,amount decimal(10,2))
create table Stock(Id int primary key, item_id int, quantity int)
create table Sales(Id int primary key,item_id int,quantity int,amount decimal(10,2))

insert into Purchases values(1,1000,4,2000),(2,1001,5,3000),(3,1002,6,4000)
insert into Stock values(101,10,3),(102,11,2),(103,12,1)
insert into Sales values(1000,20,5,1500),(1001,21,8,2000),(1002,22,10,2500)

Create trigger [add_stock] on [dbo].[Purchases] for insert
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


CREATE TRIGGER less_stock
ON dbo.Sales
FOR INSERT
AS
BEGIN
    DECLARE 
        @qty INT,
        @item_no INT,
        @id INT,
        @stock INT

    SELECT @qty = quantity FROM inserted
    SELECT @item_no = item_id FROM inserted

    SET @stock = (SELECT COUNT(*) FROM dbo.Stock WHERE item_id = @item_no)

    IF (@stock > 0)
    BEGIN
        UPDATE dbo.Stock
        SET quantity = quantity - @qty
        WHERE item_id = @item_no
    END
    ELSE
    BEGIN
        SET @id = (SELECT ISNULL(MAX(Id),0) + 1 FROM dbo.Stock)
        INSERT INTO dbo.Stock VALUES(@id, @item_no, @qty)
    END
END
GO




