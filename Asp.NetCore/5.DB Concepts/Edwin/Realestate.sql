create database RealEstate
create table Branches(Branchid int primary key Not null,Adress varchar(100),City varchar(30),Zipcode int)
Alter table Branches add State varchar(100);
select * from Branches
create table Employee(Employeeid int primary key not null, EmployeeName varchar(60),EmployeeAddress varchar(100),EmployeePhone int,Designation varchar(100),Bid int, Foreign key (Bid) REFERENCES  Branches(Branchid))
insert into Employee_Master values(102,'Joyal','10 New st.',24598760,'Manager',1123)
insert into Employee_Master values(111,'Vishnu','10 Main st.',1234567890,'Employee',1111) 


select * from Employee_Master
create table Property(Propertyid int primary key not null,PropertyAddress varchar(100),State varchar(50),City varchar(60),Zipcode int)
insert into Property values(1114,'10 Main st.','Albury','Canberra',778889,50000)
insert into Property values (225,'church street','Del','Ban',444555,150000),(5555,'Gvr','Kel','Tvr',445588,250000),(7777,'Kannur','Kel','Kan',405090,200000),(6666,'cok','kel','Tvr',778899,800000)

select * from Property where Rate>500000



create table Owner(Ownerid int primary key not null,OwnerAddress varchar(100),OwnerPhone int)
alter table Owner add OwnerName varchar(50);
insert into Owner values(200,'Gvr',1234567890,'Joyal') insert into Owner values(300,'Tsr',58986640,'Vishnu')
 insert into Owner values(400,'Cok',987858465,'Edwin') insert into Owner values(700,'MCT',778896655,'Trinita')
  insert into Owner values(8715 ,'MAL',77895566,'Trinitta')

create table PropertyOwner(PropertyOwnerid int not null,Propertyid int not null,Ownerid int not null,PrecentOwned int not null,Foreign key(Propertyid) REFERENCES Property(Propertyid), foreign key (Ownerid) REFERENCES Owner(Ownerid))
alter table Property add Rate int;

select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='Base Table'

exec sp_rename 'Employee','Employee_Master';
create view viewofEmployee as select Employeeid,EmployeeName,EmployeeAddress
from Employee_Master
select * from viewofEmployee

Alter view viewofEmployee as select Employeeid,EmployeeName from Employee_Master where Designation='Manager'
select * from viewofEmployee

insert into Branches values(1111,'10 Main st.','Canberra',734001,'Albury'),(1123,'15 New st.','Gold Creek',72656,'Glebe'),(1245,'10 Old St.','Balmain',73895,'Yamba'),(1231,'01 Carg st.','Hobart',73965,'Mudgee');



update Branches set Adress='10 new st.' where City='balmain'

delete from Branches where city='Hobart'

select * from Employee_Master where Bid=(select Branchid from Branches where city='Balmain')

select * from Property where Zipcode in(778889,444555,445588,405090,778899)
select * from Property ORDER BY Rate DESC

select Bid, Count(*) from Employee_Master group by Bid
 
 select OwnerName from Owner where OwnerName Like 'T%'

 select a.OwnerName from Owner a,PropertyOwner b where b.Propertyid='8715 ' and b.Ownerid=a.Ownerid