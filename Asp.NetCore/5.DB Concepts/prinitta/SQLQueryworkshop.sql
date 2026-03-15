create database workshop

create table branches(BranchId int identity(1,1) primary key not null, Address varchar(100) not null,State varchar(30) not null, City varchar(30) not null, Zipcode int);  
create table employee(employeeid int identity(1,1) primary key not null,Employeename varchar(30) not null, Employeeaddress varchar(100),Employeephone int, Designation varchar(100), Branchid int, FOREIGN KEY (Branchid) REFERENCES Branches (BranchId));
create table property(Propertyid int identity(1,1) primary key not null, PropertyAddress varchar(50) not null, state varchar(30), City varchar(30), Zipcode int);
create table ownerr(Ownerid int identity(1,1) primary key not null, OwnerAddress varchar(50) not null, OwnerPhone  int);
create table propertyowner(Propertyownerid int identity(1,1) primary key not null, Propertyid int not null, Percentowned int not null, FOREIGN KEY (Propertyid) REFERENCES Property (Propertyid),
FOREIGN KEY (Propertyownerid) REFERENCES ownerr (Ownerid));

select * from branches;
select * from employee;
select * from property;
select * from propertyowner;
select * from ownerr;

alter table property add Rate int;

select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='base table'

EXEC sp_rename 'employee','Employee_Master'
select * from Employee_Master;

CREATE VIEW ViewOfEmployee  AS 
            SELECT employeeid, employeename, Employeeaddress
            FROM Employee_Master

select * from ViewOfEmployee;

ALTER VIEW ViewOfEmployee AS 
	SELECT employeeid, employeename
	 FROM Employee_Master
	Where Designation='Manager'

	INSERT INTO branches 
VALUES ( '10 Main St.', 'Canberra','Albury', 734001);

INSERT INTO branches 
VALUES (' New St.', 'Gold Creek',' Glebe', 72656);

INSERT INTO branches 
VALUES ('10 Old St', 'Balmain','Yamba', 73895);

INSERT INTO branches 
VALUES ('01 Carg St.', 'Hobart','Mudgee', 73965);

		
  UPDATE branches set Address = ' New St.'
  WHERE State ='Balmain'

  delete from branches  where state='Hobart'
  
  select * from Employee_Master where BranchId= (select Branchid 
FROM branches WHERE state='Balmain')

select distinct Employeename from Employee_Master

insert into property values('chungath','kerala','thrissur','1234','400000'),
('pulikottil','tamilnadu','chennai','233445','450000'),
('cheruvathoor','agra','bangloor','5677', '300000');

insert into property values('chungath','kerala','thrissur','1234','600000');


SELECT * FROM property 
	WHERE Rate>500000

	SELECT Propertyid,PropertyAddress 
	FROM property
	WHERE Rate BETWEEN 500000 AND 3000000

select * from property
where zipcode IN (1234,233445)

select * from property
ORDER BY Rate DESC

insert into Employee_Master values('prinitta','chungath','343534','developer','1'),
('clerin','pulikottil','756748','fluter','2');
select * from Employee_Master;

select Branchid, COUNT(*) from Employee_Master
group by Branchid

insert into ownerr values('cheruvathoor',8648648),('thekekara',6787898);




