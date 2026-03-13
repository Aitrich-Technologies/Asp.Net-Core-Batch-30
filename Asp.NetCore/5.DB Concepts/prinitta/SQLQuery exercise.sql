create database exercise
create table Universityy(UID int primary key identity(1,1), Name varchar(20) not null, Chancellor varchar(20) not null)
create table collage(CID int primary key identity(1,1), Name varchar(20) not null, University int,foreign key (University) references Universityy(UID))
create table Deann(Deanid int primary key identity(1,1), Name varchar(20) not null, DateOfBirth DateTime)
create table Department(DID int primary key identity(1,1), Name varchar(20) not null,Collage int, foreign key (Collage) references collage(CID))
create table professor(PID int primary key identity(1,1), Department int , foreign key (Department) references Department(DID))
create table course(Courseid int primary key identity(1,1), Department int, foreign key (Department) references Department(DID))
create table subjects(subjectid int primary key identity(1,1), course int, foreign key(course) references course(courseid))
create table students(studentid int primary key identity(1,1), Department int, foreign key (Department) references Department(DID),)
create table student_Registration(Student int, foreign key (Student) references students(studentid), subjects int, foreign key(subjects) references subjects(subjectid))

insert into Universityy values('prinitta',3444);
select * from Universityy;

insert into collage values('Clerin','1');
select * from collage;

insert into Deann values('Joyal','2002-04-18');
select * from Deann;

insert into Department values( 'MCA','4');
select * from Department;

insert into professor values('1')
select * from professor;

SELECT 
    s.StudentName,
    c.CollegeName,
    co.CourseName,
    p.ProfessorName
FROM Students s
JOIN Departments d ON s.DepartmentID = d.DepartmentID
JOIN Colleges c ON c.CollegeID = d.DepartmentID
JOIN Courses co ON co.DepartmentID = d.DepartmentID
JOIN Professors p ON p.DepartmentID = d.DepartmentID;








