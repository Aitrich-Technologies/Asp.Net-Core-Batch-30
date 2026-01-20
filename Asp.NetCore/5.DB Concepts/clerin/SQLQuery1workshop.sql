create database workshop

create table Branches(company_id int primary key not null,name varchar(100),remarks varchar(200));

CREATE PROCEDURE Branches_insert
(
    @v_name VARCHAR(100),
    @v_remarks VARCHAR(250)
)
AS
BEGIN
    DECLARE @v_id INT;

    SELECT @v_id = ISNULL(MAX(company_id), 0) + 1
    FROM Branches;

    INSERT INTO Branches (company_id, name, remarks)
    VALUES (@v_id, @v_name, @v_remarks);
END;
GO


EXEC Branches_insert 'aitrich','good'
EXEC Branches_insert 'wipro','good';
EXEC Branches_insert 'infosys','good';

select *  from Branches

CREATE PROCEDURE Branches_update
(
    @v_id INT,
    @v_name VARCHAR(100),
    @v_remarks VARCHAR(250)
)
AS
BEGIN
    UPDATE Branches
    SET 
        name = @v_name,
        remarks = @v_remarks
    WHERE company_id = @v_id;
END;
GO


EXEC Branches_update  1,'aitrich technologies','very good';


CREATE PROCEDURE Branches_Delete
(
    @v_id INT
)
AS
BEGIN
    DELETE FROM Branches
    WHERE company_id = @v_id;
END;
GO

EXEC Branches_Delete 1;

CREATE PROCEDURE deleteProcs
(
    @v_tname VARCHAR(50),
    @v_fname VARCHAR(50),
    @v_id INT
)
AS
BEGIN
    DECLARE @sql NVARCHAR(500);

    SET @sql = 
        'DELETE FROM ' + @v_tname +
        ' WHERE ' + @v_fname +
        ' = ' + CAST(@v_id AS VARCHAR(20));

    EXEC (@sql);
END;
GO


EXEC deleteProcs 'Branches','company_id',2


CREATE PROCEDURE Selectprocss
(
    @v_name VARCHAR(50)
)
AS
BEGIN
    EXEC (
        'SELECT * FROM Branches WHERE name = ''' + @v_name + ''''
    );
END;
GO

EXEC Selectprocss 'aitrich';
EXEC Selectprocss 'tcs';



create proc selectproc1
(
@v_tname varchar(50)
)
as begin
exec('select * from Branches '+@v_tname)
end
Go




EXEC selectproc1 'WHERE company_id = 3';
EXEC selectproc1 'WHERE name = ''Infosys'''; 



CREATE PROC selectProc3
(
    @v_tname VARCHAR(50) = NULL
)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX)

    SET @sql = 'SELECT * FROM Branches '

    IF @v_tname IS NOT NULL
        SET @sql = @sql + @v_tname

    EXEC(@sql)
END
GO


EXEC selectproc3;


CREATE FUNCTION dbo.company_id()
RETURNS BIGINT
AS
BEGIN
    DECLARE @Branches_id BIGINT;

    SELECT @Branches_id = ISNULL(MAX(company_id), 0) + 1
    FROM Branches;

    RETURN @Branches_id;
END;
GO

select dbo.company_id() as NextCompanyid;


create Function dbo.Get_fullname
(
@field1 varchar(50),
@field2 varchar(50)
)
returns varchar(100)
begin
Return (@field1+','+@field2)
End
Go

SELECT dbo.Get_fullname(name, remarks)as Full_name FROM Branches









create table purchase(id varchar(100) primary key,item_id int,Quantity int,amount decimal(10,2));
create table Stock(id int primary key,item_id int,quantity decimal(10,2));
create table sales(salesid int primary key,item_id int,quantity int,amount decimal(10,2));

insert into purchase values(1,100,2,1000.90);
insert into Stock values(1,1,2.00);
insert into sales values(1,1,4,9000.00);

select * from purchase;
select * from Stock;
select * from sales;



CREATE FUNCTION dbo.get_purchasecode()
RETURNS VARCHAR(50)
AS
BEGIN
    DECLARE @purchase_code VARCHAR(50);

    SELECT @purchase_code =
        'PU' +
        LEFT('00000000', 8 - LEN(LTRIM(STR(RIGHT(MAX(id), 8) + 1)))) +
        LTRIM(STR(RIGHT(MAX(id), 8) + 1))
    FROM purchase;

    RETURN ISNULL(@purchase_code, 'PU00000001');
END;
GO


SELECT dbo.get_purchasecode();





create trigger [add_stock] on[dbo].[purchase] for insert 
as begin
declare @qty as float,@item_no as bigint,@id as bigint,@stock as float
select @qty=(select quantity from inserted)
select @item_no=(select item_id from inserted)
set @stock=(select count(*) from stock  where item_id=@item_no)
if @stock>0
begin
   update stock set quantity=quantity+@qty where item_id=@item_no
   end
   else
    begin
       
       set @id=(select ISNULL(max(id),0)+1 from Stock)
       insert into Stock values(@id,@item_no,@qty)

       end
       end 
       
       

       CREATE TRIGGER less_stock
ON dbo.sales
FOR INSERT
AS
BEGIN
    DECLARE 
        @qty FLOAT,
        @item_no BIGINT,
        @id BIGINT,
        @stock FLOAT;

    SELECT @qty = quantity FROM inserted;
    SELECT @item_no = item_id FROM inserted;

    SET @stock = (SELECT COUNT(*) FROM stock WHERE item_id = @item_no);

    IF (@stock > 0)
    BEGIN
        UPDATE stock
        SET quantity = quantity - @qty
        WHERE item_id = @item_no;
    END
    ELSE
    BEGIN
        SET @id = (SELECT ISNULL(MAX(id), 0) + 1 FROM stock);

        INSERT INTO stock
        VALUES (@id, @item_no, @qty);
    END
END;
GO












 






