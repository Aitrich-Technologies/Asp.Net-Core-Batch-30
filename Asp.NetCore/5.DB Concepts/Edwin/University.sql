create database Universitys
create table Universityy( UID int primary key, Name varchar(20), Chancellor varchar(20));

insert into Universityy values(1, 'Calicut University', 'Ravi'),(2, 'Kerala University', 'Mohan');




create table Deans (DeanID int primary key,Name varchar(20),DateOfBirth DATETIME);

insert into Deans values(1, 'Aswin ', '1975-05-12'),(2, 'Unni ', '1972-08-20');

update Deans set Name = 'Renuka Mukerjee'where Name = 'Aswin';


create table College ( CID int primary key,  University INT,  Dean INT,  Name VARCHAR(20),FOREIGN KEY (University) REFERENCES Universityy(UID),FOREIGN KEY (Dean) REFERENCES Deans(DeanID));

insert into College  values(101, 1, 1, 'Aitrich '),(102, 2, 2, 'Tech College');

create table Departments ( DID int primary key, College INT, Name VARCHAR(20), FOREIGN KEY (College) REFERENCES College(CID));

insert into Departments values(1, 101, 'MCA'),(2, 101, 'BCA');

select * from Departments;

create table Professor (PID int primary key,Department INT,Name VARCHAR(20),FOREIGN KEY (Department) REFERENCES Departments(DID));

insert into Professor values(1, 1, 'Naveen'),(2, 2, 'Benlin');

create table Course (CourseID int primary key,Department int,Name varchar(20),FOREIGN KEY (Department) REFERENCES Departments(DID));

insert into Course values(1, 1, 'MCA'),(2, 2, 'B.Tech C.S');


create table Subjects (SubjectID int primary key,Course int,Professor int,Name varchar(20),FOREIGN KEY (Course) REFERENCES Course(CourseID),FOREIGN KEY (Professor) REFERENCES Professor(PID));

insert into Subjects values(1, 1, 1, 'Computer Networks'),(2, 2, 2, 'Data Structures');


create table Student (StudentID int primary key, Department INT, Name varchar(20), DateofEnrollment SMALLDATETIME, TelephoneNumber varchar(20), FOREIGN KEY (Department) REFERENCES Departments(DID));

insert into Student values(1, 1, 'Vishnu', '2023-06-01', '9999999999'),(2, 2, 'Joyal', '2023-06-05', '8888888888');

update Student set TelephoneNumber = '8105874639' where Name = 'Vishnu';
select * from Student;






create table Studente_Reg (Student int,Subject int,FOREIGN KEY (Student) REFERENCES Student(StudentID),FOREIGN KEY (Subject) REFERENCES Subjects(SubjectID));

insert into Studente_Reg values(1, 1),(2, 2);




create view  studentCourseses as select  s.StudentID,s.Name as studentName,c.CourseID,c.Name as CourseName , from Student s
inner join Course c on s.Department = c.Department;
select * from studentCourseses


 
select   st.StudentID,st.Name AS StudentName,cl.Name AS CollegeName,co.Name AS CourseName,p.Name AS ProfessorName FROM Student st
INNER JOIN Departments d ON st.Department = d.DID
INNER JOIN College cl ON d.College = cl.CID
INNER JOIN Course co ON d.DID = co.Department
INNER JOIN Subjects sub ON co.CourseID = sub.Course
INNER JOIN Professor p ON sub.Professor = p.PID;

select distinct p.PID,p.Name as ProfessorName from Professor p
inner join  Subjects sub on p.PID = sub.Professor
inner join Course c on sub.Course =c.CourseID
inner join Departments d on c.Department = d.DID where d.Name='MCA'

select distinct c.CourseID, c.Name as CourseName from Professor p
inner join Subjects sub on p.PID =sub.Professor
inner join Course c  on sub.Course = c.CourseID
where p.Name='Naveen'

select d.Name as DepartmentName,count(s.StudentID)as totalstudent from Student s
inner join Departments d on s.Department =d.DID
group by d.Name;


select CID,Name,University,Dean from College order by Name DESC;

select sub.SubjectID,sub.Name as SubjectName from Subjects sub
inner join Course c on sub.Course = c.CourseID where c.Name='B.Tech C.S';


select count(*) as ComputerCourses from Course where Name = 'B.Tech C.S';

select sub.Name as SubjectName,p.Name as ProfessorName from Subjects sub
inner join Professor p on sub.Professor=p.PID order by sub.Name;  





