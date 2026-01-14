create table Branches(Branch_id int,Address varchar(100),state varchar(30),city varchar(30),Zipcode int,
primary key(Branch_id));

create table Employee(Employee_id int not null,EmployeeName varchar(50) not null,EmployeeAddress varchar(100),
EmployeePhone integer,Designation varchar(100),B_id integer,primary key(Employee_id),foreign key(B_id) references 
Branches(Branch_id));

INSERT INTO Employee_Master VALUES (1,'Anu','aitrich',907543,'Manager',3);
INSERT INTO Employee_Master VALUES (2,'Ashwin','alouytr',9075893,'HR',3);
INSERT INTO Employee_Master VALUES (3,'Ammu','adefwg',907903,'Manager',3);

INSERT INTO Branches VALUES (3,'Main Rd','Kerala','Kochi',682001);




create table Property(Property_id int not null,propertyAddress varchar(50) not null,state varchar(30),city varchar(30),
Zipcode int,primary key(Property_id));

create table Owner(Owner_id int not null,OwnerAddress varchar(50) not null,OwnerPhone int,primary key(Owner_id));


CREATE TABLE PropertyOwner (
    Property_id INT NOT NULL,
    Owner_id INT NOT NULL,
    Percent_Owned INT NOT NULL,
    PRIMARY KEY (Property_id),
    FOREIGN KEY (Property_id) REFERENCES Property(Property_id),
    FOREIGN KEY (Owner_id) REFERENCES Owner(Owner_id)
);


select* from Branches;

select * from Employee;

select * from Property;

select * from Owner;

select * from PropertyOwner;


Alter table Property Add Rate int

select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='Base Table';

exec sp_rename 'Employee', 'Employee_Master';

select * from Employee_Master;




create view ViewOfEmployee As select Employee_id,EmployeeName,EmployeeAddress from Employee_Master;


select * from ViewOfEmployee;


ALTER VIEW ViewOfEmployee AS
SELECT Employee_id, EmployeeName
FROM Employee_Master
WHERE Designation = 'Manager';
GO


Drop view ViewOfEmployee;

insert into Branches values(1111,'10 Main st.','canberra','Albury',734001);
insert into Branches values(1123,'15 New st.','Gold creek','Glebe',72656);
insert into Branches values(1245,'10 Old st.','Balmain','yamba',73895);
insert into Branches values(1231,'01 carg st.','Hobart','Mudgee',73965);

update Branches set Address='10 new st' where state='Balmain';

delete from branches where state='Hobart';

select * from Employee_Master where B_id=(select Branch_id from Branches where state='Balmain');

select Distinct EmployeeName from Employee_Master;



ALTER TABLE Property ADD Rate INT;
GO


INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (1, 'MG Road', 'Kerala', 'Kochi', 682001, 750000);


INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (2, 'vjhkb', 'kerala', 'Thrissur', 789654, 600000);

INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (3, 'palarivattam', 'kerala', 'ernakulam', 789654, 2400000);

INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (4, 'ollur', 'kerala', 'idukki', 7897234, 2987000);


select * from Property;

SELECT Property_id FROM Property;


select * from Property where Rate>500000


SELECT Property_id,PropertyAddress 
	FROM Property
	WHERE Rate BETWEEN 500000 AND 3000000;


ALTER TABLE Owner ADD Name varchar(67);
GO

insert into Owner values(1,'ramavarmapuram',23456789,'Teena');
insert into Owner Values(2,'ollur',456789,'Clerin');
insert into Owner Values(3,'thiroor',768789,'telna');

select Name from Owner where Name like 'T%';

SELECT * FROM Property
	WHERE Zipcode IN (734001, 72656, 73965, 73895) 

    INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (9, 'hbjk', 'kerala', 'idukki', 734001, 2987000);
    INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (10, 'oknk', 'kerala', 'idukki', 72656, 2987000);
    INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (11, 'sjkbn', 'kerala', 'idukki', 73965, 2987000);
    INSERT INTO Property (Property_id, propertyAddress, state, city, Zipcode, Rate)
VALUES (12, 'ollur', 'kerala', 'idukki', 73895, 2987000);

select * from Property  Order By Rate Desc;

select B_id, Count(*) from Employee_Master Group By B_id;

SELECT a.Name FROM Owner a, Property_Owner b
	WHERE b.Property_id=’8715’ AND b.Owner_id=a.Owner_id



















