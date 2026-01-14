create database University_information

create table University(
UID int primary key,
Name varchar(20),
Chancellor varchar(20)
);
insert into University values(1,'Oxford','David Billa'),(2,'Cambridge','Christian fallesa'),(3,'Harvard','Gregarios');
select * from University

create table College(
CID int primary key,
University int not null foreign key (University)references University(UID),
Dean int not null foreign key (Dean) references Dean(DeanID),
Name varchar(20)
);
insert into College values(101,1,11,'Engineering'),(102,2,12,'Science'),(103,3,13,'Arts');
select * from College

create table Dean(
DeanID int primary key,
Name varchar(20),
DateOfBirth DateTime
);
insert into Dean values(11,'Robert','1977-05-15'),(12,'Alice','1975-09-19'),(13,'Charlie','1980-10-24');
select * from  Dean
update Dean set Name ='Renuka Mukerjee' where Name = 'Alice';



create table Department(
DID int primary key,
College int foreign key(College) references College(CID),
Name varchar(20)
);
insert into Department values(1,101,'MCA'),(2,102,'Computer Science'),(3,103,'Physics');
select * from Department

create table Professor(
PID int primary key,
Department int foreign key(Department) references Department(DID),
Name varchar(20)
);
insert into Professor values(01,1,'George Peter'),(02,2,'Alice Mandalin'),(03,3,'Peter Charlie');
select * from Professor

create table Course(
CourseID int primary key,
Department int foreign key(Department) references Department(DID),
Name varchar(20)
);
insert into Course values(10,1,'BTech CS'),(20,2,'BCom CS'),(30,3,'BVoc');
select * from Course

create table Subject(
SubjectID int primary key,
Course int foreign key(Course) references Course(CourseID),
Professor int foreign key(Professor) references Professor(PID),
Name varchar(20)
);
insert into Subject values(1,10,01,'Python'),(2,20,02,'DBMS'),(3,30,03,'OOPS');
select * from Subject

create table Student(
StudentID int primary key,
Department int foreign key (Department)references Department(DID),
Name varchar(20),
DateOfEnrollment smalldatetime,
TelephoneNumber varchar(20)
);
insert into Student values(1,1,'Kumar Varma','2023-08-15','8956478567'),
(2,2,'James','2022-07-18','2343568679'),(3,3,'Milner','2024-6-11','6546347600');
select * from Student
update Student set TelephoneNumber ='8105874639' where Name ='Kumar Varma';



create table Student_Registration(
Student int foreign key(Student) references Student(StudentID),
Subject int foreign key(Subject) references Subject(SubjectID)
);
insert into Student_Registration values(1,1),(2,2),(3,3);
select * from  Student_Registration




CREATE VIEW StudentCourses AS
SELECT 
    s.StudentID,
    s.Name AS StudentName,
    c.CourseID,
    c.Name AS CourseName
FROM Student s
INNER JOIN Course c ON s.Department = c.Department;

SELECT * FROM StudentCourses;



SELECT 
    st.StudentID,
    st.Name AS StudentName,
    cl.Name AS CollegeName,
    co.Name AS CourseName,
    p.Name AS ProfessorName
FROM Student st
INNER JOIN Department d ON st.Department = d.DID
INNER JOIN College cl ON d.College = cl.CID
INNER JOIN Course co ON d.DID = co.Department
INNER JOIN Subject sub ON co.CourseID = sub.Course
INNER JOIN Professor p ON sub.Professor = p.PID;



select distinct p.PID,p.Name AS ProfessorName
from Professor p
inner join Subject sub on p.PID = sub.Professor
inner join Course C on sub.Course = c.CourseID
inner join Department d on c.Department = d.DID
where d.Name = 'MCA';



select distinct c.CourseID,c.Name as CourseName
from Professor p
inner join Subject sub on p.PID = sub.Professor
inner join Course c on sub.Course = c.CourseID
where p.Name = 'George Peter';



select d.Name as DepartmentName, 
count(s.StudentID)as TotalStudents
from Student s
inner join Department d on s.Department =d.DID
group by d.Name;



select CID,Name,University,Dean
from College
order by Name desc;



select sub.SubjectID,sub.Name as SubjectName
from Subject sub
inner join Course c on sub.Course = c.CourseID
where c.Name = 'BTech CS';



select count(distinct c.CourseID) as numberofCourses from Course c
inner join Subject  sub on c.CourseID = sub.Course
where sub.Name LIKE 'DBMS';



select sub.Name as SubjectName,p.Name as ProfessorName
from Subject sub 
inner join Professor p on sub.Professor = p.PID
order by sub.Name;




SELECT * FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'


