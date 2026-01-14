create database DB_RealEstate

create table Branches(
BranchID int primary key not null,
Address varchar(100),
State varchar(30),
City varchar(30),
Zipcode int
);


create table Employee(
EmployeeID int primary key not null,
EmployeeName varchar(50) not null,
EmployeeAddress varchar(100),
EmployeePhone int,
Designation varchar(100),
B_ID int foreign key (B_ID) REFERENCES Branches(branchID)
);


CREATE TABLE Property(
Property_ID int primary key not null,
PropertyAddress varchar(50) not null,
State varchar(30),
City varchar(30),
Zipcode int
);


create table Owner(
Owner_ID int primary key not null,
Owner_Address varchar(50) not null,
Owner_Phone int
);
alter table Owner add Owner_Name varchar(100)
select * from Owner

create table PropertyOwner(
PropertyOwner_ID int not null,
Property_ID int not null foreign key(Property_ID)references Property(Property_ID),
Owner_ID int not null foreign key (Owner_ID) references Owner(Owner_ID),
Percent_Owned int not null
);


alter table Property add Rate int

select * from INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'

EXEC sp_rename 'Employee','Employee_Master'

CREATE  VIEW ViewofEmployee_Master 
AS select EmployeeID,EmployeeName,EmployeeAddress
from  Employee_Master;

alter view ViewofEmployee_Master AS
select EmployeeID,EmployeeName
from  Employee_Master
where Designation = 'Manager'


insert into Branches values(1111,'10 Main St.','Canberra','Albury',734001),
(1123,'15 New St.','Gold Creek','Glebe',72656),
(1245,'10 Old St.','Balmain','Yamba',73895),
(1231,'01 Carg St.','Hobalt','Mudgee',73965);

update Branches set Address = '10 NEW St.'
where State = 'Balmain'

delete from Branches
where State ='Hobalt'

select * from Branches

INSERT INTO Employee_Master
VALUES
    (101, 'Alice', 'BTM Layout', 987, 'Manager', 1111),
    (102, 'Bob', 'Salt Lake', 912, 'Developer', 1123),
    (103, 'Charlie', 'Indiranagar', 998, 'Tester', 1245);



select * from Employee_Master
where B_ID =(select BranchID 
from Branches
where state = 'Balmain')



SELECT DISTINCT EmployeeName 
FROM Employee_Master

insert into Property values(111,'LANE12','Kerala','thrissur',123,5000000),
(222,'LANE123','TamilNadu','Chennai',124,500000),
(333,'LANE1234','Mumbai','Wankhadai',145,2500000);
insert into Property values(444,'LANE12345','Pune','thirir',324,3500000);

delete from Property
where City ='Ernakulam'



SELECT * FROM property 
WHERE Rate>500000

select Property_ID,PropertyAddress 
from Property
where Rate between 2500000 AND 50000000



insert into Owner values(12,'kolkata',321,'Tharadas'),(13,'hyderabad',453,'Ronaldo'),(31,'Mumbai',678,'Tyson');
SELECT Owner_Name
FROM Owner
WHERE Owner_Name LIKE 'T%';

SELECT * FROM Property
WHERE Zipcode IN (123, 124, 145, 324) 

select * from Property
order by Rate DESC

select B_ID, count(EmployeeName) as NO_OF_EMP from Employee_Master
group by B_ID

INSERT INTO PropertyOwner VALUES(1, 111, 12, 50),   (2, 222, 13, 50),  (3, 333, 12, 100), (4, 444, 13, 100);

select * from PropertyOwner


SELECT a.Owner_Name FROM Owner a join PropertyOwner b
	 on b.Owner_ID=a.Owner_ID
     WHERE b.Property_ID=333;




     drop table Owner

     )
