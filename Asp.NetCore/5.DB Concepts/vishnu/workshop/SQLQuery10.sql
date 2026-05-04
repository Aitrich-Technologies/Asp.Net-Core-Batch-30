create database DB_RealEstate

create table Branches(Branchid int primary key not null,Address varchar(100), State varchar(30) , City varchar(30), Zipcode int)

create table Employee(Employeeid int primary key not null,EmployeeName varchar(50) not null, EmployeeAddress varchar(100) , EmployeePhone int, Designation varchar(100),Bid int, foreign key (Bid) references Branches(branchid))

create table Property(Propertyid int primary key not null, PropertyAddress varchar(50) not null, State varchar(30), City varchar(30), Zipcode int)

create table Owner(Ownerid int primary key not null, OwnerAddress varchar(50) not null , OwnerPhone int)

create table PropertyOwner(PropertyOwnerid int primary key not null,Propertyid int not null, Ownerid int not null, Percent_Ownered int not null, foreign key (Propertyid) references Property(Propertyid), foreign key (Ownerid) references Owner(Ownerid))

alter table property add Rate int


select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='BASE TABLE'


exec sp_rename 'employee' , 'Employee_Master'


create view viewofemployee as select employeeid,employeename,employeeaddress from Employee_Master


alter view viewofemployee as select employeeid, employeename from employee_master where designation = 'manager'

select * from Branches


insert into Branches values (1111, '10 Main St.', 'Canberra',' Albury', 734001),(1123, '15 New St.', 'Gold Creek', 'Glebe', 72656), (1245, '10 Old St', 'Balmain', 'Yamba', 73895),(1231, '01 Carg St.', 'Hobart',' Mudgee', 73965)

update Branches set Address ='10 new st.' where State='balmain'


delete from Branches where state='hobart' 

select * from Employee_Master where bid =(select branchid from Branches where state= 'balmain')

select * from Employee_Master

insert into  employee_master values(101,'vishnu','10 Main St.',123456,'developer',1111),(102,'edwin','110 Old St',4563210,'developer',1123);
insert into  employee_master values(103,'joyal','10 Main St.',123456,'developer',1111)

select distinct employeename from Employee_Master


select * from Property

insert into Property values (8715,'10 Main St.','Canberra','Albury',734001,50000),(1534,'15 New St.','Gold Creek', 'Glebe',72656,80000),(5467, '15 New St.', 'Gold Creek', 'Glebe', 73965 ,800000),(7468, '01 Carg St.', 'Hobart',' Mudgee', 73895,40000),(7741,'kkm','kerala','thrissur',112254,120000),(1123, '01 Carg St.', 'Hobart',' Mudgee', 220014,300000)


select * from Property where rate>500000

select propertyid,propertyaddress from Property where rate between 50000 and 300000

select * from Property where Zipcode in (734001, 72656, 73965) 

select * from Property order by rate desc 


select bid,count(*) from employee_master group by bid

select * from Owner

alter table owner add ownername varchar(100)


insert into owner values (101,'thrissur',12456,'tovino'),(102,'kochi',54782315,'thomas'),(103,'thrissur',12456,'ravi')
insert into owner values (8715,'thrissur',12456,'ram')
insert into owner values (7468,'01 Carg St.',12456,'tom')

select ownername from Owner where Ownername like 't%'

select a.ownername from owner a, PropertyOwner b where b.Propertyid='7468' and b.Ownerid=a.Ownerid


