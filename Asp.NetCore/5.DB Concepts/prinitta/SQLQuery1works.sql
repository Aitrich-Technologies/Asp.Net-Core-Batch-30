create database workshops

create table Companyy(Company_id int primary key, Name varchar(100) not null, Remarks varchar(250) not null) 


CREATE PROC Companyy_Insert
(
    @v_name VARCHAR(100),
    @v_remarks VARCHAR(250)
)
AS
BEGIN
    DECLARE @v_id INT;

    SELECT @v_id = ISNULL(MAX(Company_id), 0) + 1
    FROM Companyy;

    INSERT INTO Companyy (Company_id, Name, Remarks)
    VALUES (@v_id, @v_name, @v_remarks);
END;
GO

EXEC Companyy_Insert 'Aitrich', 'Good';
EXEC Companyy_Insert 'Wipro', 'Good';
EXEC Companyy_Insert 'Infosys', 'Good';


create proc Companyy_update
(
@v_id as int,
@v_name as varchar(100),
@v_remarks as varchar(250))
as
begin
update Companyy set name= @v_name,remarks=@v_remarks where Company_id=@v_id
end
go
exec Companyy_update 1,'aitrich rechnologoes','Very Good'

select * from Companyy


create proc Companyy_delete
(
@v_id as int)
as
begin
delete from Companyy where Company_id=@v_id
end
go
exec Companyy_delete 1


CREATE PROC deleteProceee
(
    @v_tname VARCHAR(50),
    @v_fname VARCHAR(20),
    @v_id INT
)
AS
BEGIN
    DECLARE @sql NVARCHAR(400);

    SET @sql = 
        'DELETE FROM ' + QUOTENAME(@v_tname) +
        ' WHERE ' + QUOTENAME(@v_fname) + ' = @id';

    EXEC sp_executesql 
        @sql,
        N'@id INT',
        @id = @v_id;
END;
GO
EXEC deleteProceee 'Companyy', 'Company_id', 3;

select *from Companyy

CREATE PROC selectProceee
(
    @v_name VARCHAR(50)
)
AS
BEGIN
    EXEC ('SELECT * FROM Companyy WHERE Name = ''' + @v_name + '''');
END;
GO
EXEC selectProceee 'Wipro';

create proc selectproc1
(
@v_tname varchar(50)
)
AS
BEGIN
exec('select*from Companyy'+@v_tname)
end
go

EXEC selectproc1 'where id=3'
EXEC selectproc1 'where name="Infosys"'
EXEC selectproc1 'where remarks='''' and id=3'


create proc selectproc2
(
@v_tname varchar(50)=NULL
)
AS
BEGIN
exec('select * from company'+@v_tname)
END
GO
EXEC selectproc2


CREATE FUNCTION dbo.companyyy()
RETURNS BIGINT
AS
BEGIN
    DECLARE @company_id BIGINT;

    SELECT @company_id = ISNULL(MAX(company_id), 0) + 1
    FROM Companyy;

    RETURN @company_id;
END;
GO

SELECT dbo.companyyy() AS NextCompanyID;


create function dbo.get_fullname
(
@feild1 varchar(50),
@feild2 varchar(50)
)
RETURNS varchar(100)
BEGIN
RETURN (@feild1 +','+@feild2)
END
go
SELECT dbo.Get_fullname(name, remarks)as Full_name FROM Company


create function dbo.GetTable
(
@Name as varchar(30)
)
RETURNS Table 
AS
RETURN SELECT*FROM company where name=@Name
go
SELECT * from dbo.GetTable('Infosys')


create  table purchase(id varchar(25) primary key, item_id int, Quantity int, Amount decimal)

insert into purchase values(1,100,2,20000.00);

select * from purchase

create table stock(id int primary key, item_id int,Quantity decimal(10,2))

insert into stock values(1,1,2.05);

create table saless(id int primary key, item_id int, quantity int, Amount decimal)
insert into saless values(1,1,4,9000.00)

create trigger [add_stock] on [dbo].[purchase] 
for insert
as
begin
declare @qty as float,@item_no as bigint,@id as bigint,@stock as float
select @qty=(select quantity from inserted)
select @item_no=(select item_id from inserted)
set @stock=(select count(*)from stock where item_id=@item_no)
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


select * from purchase
select * from saless
select * from stock










