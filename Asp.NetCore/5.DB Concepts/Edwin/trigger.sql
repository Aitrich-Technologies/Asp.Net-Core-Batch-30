create database Triggeres
create table Patients(PatientId int identity(1,1) primary key,FullName varchar(100),Age int,Gender Char(1),ContactNumber varchar(15),createdAt Datetime default getdate())
create table AuditLog(LogId int identity(1,1) primary key,ActionPeroformed varchar(50),PatientId int,PerformedAt datetime default getdate())

create trigger trg_PatientAudit
on Patients
after insert
as 
begin
set nocount on;
 insert into AuditLog(ActionPeroformed,PatientId,PerformedAt)
 select 'New Patient Registered',PatientId,getdate()
 from inserted;
 end;

 insert into Patients(FullName,Age,Gender,ContactNumber) values('Edwin',21,'M','9846405844');

 select * from AuditLog
 select * from  Patients


 create table Employees(EmployeeId int primary key,Name varchar(100), Salary decimal(10,2))
 drop table Employees;
 create table EmployeesSalaryAduit(AduitId int identity(1,1) primary key,EmployeeId int,OldSalary decimal(10,2),NewSalary decimal(10,2),ChangeDate datetime default getdate())
CREATE TRIGGER trg_AuditSalaryChange

ON Employees
AFTER UPDATE
AS
BEGIN
    
    INSERT INTO EmployeesSalaryAduit (EmployeeId, OldSalary, NewSalary, ChangeDate)
    SELECT i.EmployeeId, d.Salary, i.Salary, GETDATE()
    FROM inserted i
    INNER JOIN deleted d ON i.EmployeeId = d.EmployeeId
    WHERE i.Salary <> d.Salary;  

end;
 insert into Employees(EmployeeId, Name, Salary) values(1,'Vishnu',100000);
 update Employees
 set Salary=50000
 where EmployeeId=1;
 select* from EmployeesSalaryAduit;
 select * from Employees;

 create table Employee(EmployeeId int primary key,Name varchar(100),Department Nvarchar(50),Salary Decimal(10,2))
 create table EmployeeAudit(AduitId int identity(1,1) primary key,EmployeeId int ,name varchar(100),Department nvarchar(50),Salary decimal(10,2),DeletedAt DATETIME DEFAULT GETDATE())
 create trigger tgr_AuditEmployeeDeletion
 on Employee
 after delete
 as
 begin
 set nocount on;
 insert into EmployeeAudit(EmployeeId,Name,Department,Salary,DeletedAt)
 select EmployeeId,Name,Department,Salary,getdate()
 from deleted;
     PRINT 'Audit log created for deleted employee(s)';
END;
insert into Employee(EmployeeId,Name,department,Salary) values(1,'vishnu','IT',100000)


insert into Employee(EmployeeId,Name,department,Salary) values(2,'Ani','Mech',50000)

delete from Employee where EmployeeId=1;

Select * from EmployeeAudit
select * from Employee
