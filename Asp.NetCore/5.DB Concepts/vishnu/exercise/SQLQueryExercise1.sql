create database University_Informations

create table University(UID int,Name varchar(20),Chancellor varchar(20),primary key(UID));

select * from University;

create table Dean(DeanID int,Name varchar(20),DateOfBirth DateTime,primary key(DeanID));
select * from Dean;



create table College(CID int,Name varchar(20),primary key(CID),UID int,foreign key(UID) references University (UID),
DeanID int,foreign key(DeanID) references Dean (DeanID));

select * from College;

create table Department(DID int,Name varchar(20),primary key (DID),CID int,foreign key(CID) references College (CID));

select * from Department;

create table Professor(PID int,Name varchar(20),primary key(PID),DID int,foreign key(DID) references Department (DID));

select * from Professor;

create table Cource(CourceID int,Name varchar(20),primary key (CourceID),DID int,foreign key(DID) references Department (DID));

select * from Cource;

create table Subject(SubjectID int,Name varchar(20),primary key(SubjectID),CourceID int,foreign key(CourceID) references
Cource (CourceID),PID int,foreign key(PID) references Professor(PID)
);

select * from Subject;

create table Student(StudentID int,Name varchar(20),DateOfEnrollment smallDateTime,TelephoneNumber varchar(20),
primary key(StudentID),DID int,foreign key(DID) references  Department(DID));




select * from Student;


CREATE TABLE Student_Registration (
    StudentID INT NOT NULL,
    SubjectID INT NOT NULL,

    CONSTRAINT PK_Student_Registration 
        PRIMARY KEY (StudentID, SubjectID),

    CONSTRAINT FK_StudentRegistration_Student
        FOREIGN KEY (StudentID) 
        REFERENCES Student(StudentID),

    CONSTRAINT FK_StudentRegistration_Subject
        FOREIGN KEY (SubjectID) 
        REFERENCES Subject(SubjectID)
);

select * from Student_Registration;

insert into University values(1,'clerin paul','peter john');
insert into University values(2,'peter','Ashwin');
insert into University values(3,'Elwin','clince');
insert into University values(4,'Ammu','joel');


insert into Dean Values(1,'Renuka sharma','1990-06-15');
insert into Dean Values(2,'Anitta','2025-04-26');
insert into Dean values(3,'Aleena','2020-03-12');
insert into Dean values(4,'Alwin','2024-03-28');

insert into College values(1,'Aland',1,1);
insert into College values(2,'smiya',2,2);
insert into College values(3,'Peter',3,3);
insert into College values(4,'Akshay',4,4);

insert into Department values(1,'megha',1);
insert into Department values(2,'Reshmika',2);
insert into Department values(3,'Dilna',3);
insert into Department values(4,'anjana',4);

insert into Professor values(1,'Edwin',1);
insert into Professor values(2,'Amritha',2);
insert into Professor values(3,'jinitha',3);
insert into Professor values(4,'vishnu',4);

insert into Cource values(1,'seena',1);
insert into Cource values(2,'Aswathy',2);
insert into Cource values(3,'Aami',3);
insert into Cource values(4,'Ameya',4);

insert into Subject values(1,'prinitta',1,1);
insert into Subject values(2,'sherin',2,2);
insert into Subject values(3,'irin',3,3);
insert into Subject values(4,'merin',4,4);

insert into Student values(1,'Anu','2025-12-21','6783259087',1);
insert into Student values(2,'Kumar varma','2025-10-27','2345678901',2);
insert into Student values(3,'mariya','2023-06-02','8976543210',3);
insert into Student values(4,'liya','2023-04-01','3456789987',4);


Alter table Cource Add Cources varchar(50);


update Cource set Cources='java' where CourceID=1;
update Cource set Cources='.NET' where CourceID=2;
update Cource set Cources='flutter' where CourceID=3;
update Cource set Cources ='React' where CourceID=4;


create view  ViewOfCource As select Name,Cources from Cource;

select * from ViewOfCource;

update Dean  set Name='Renuka Mukarjee' where DeanID=1;

update Student set TelephoneNumber='8105874639' where Name='Kumar Varma';


select * from INFORMATION_SCHEMA.TABLES where TABLE_TYPE='Base Table';

alter table Department Add  DepartmentNames varchar(50);


update  Department set DepartmentNames='MCA'where DID=1;
update Department set DepartmentNames='BCA' where DID=2;
update Department set DepartmentNames='MCA' where DID=3;
update Department set DepartmentNames='MSC' where DID=4;


SELECT p.Name AS ProfessorName
FROM Professor p
 JOIN Department d ON p.DID = d.DID
WHERE d.DepartmentNames = 'MCA';


































