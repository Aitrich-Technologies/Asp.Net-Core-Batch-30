create database University_System

create table University(
UID int primary key,
Name varchar(40),
Chancellor varchar(40)
);

create proc University_Insert
@v_UID as int,
@v_name as varchar(40),
@v_chancellor as varchar(40)
AS
begin
insert into University values (@v_UID,@v_name,@v_chancellor)
end 
go

exec University_Insert 1,'Oxford University','Chris  Patter';
exec University_Insert 2,'Cambridge University','Alice wonderlanaa';
exec University_Insert 3,'Malana University','Thalapathy VetriKONDAN';

create proc updateUniversity
@v_UID INT,
@v_name varchar(40),
@v_chancellor varchar(40)
as
begin
update University
set Name = @v_name,
Chancellor = @v_chancellor
WHERE UID = @v_UID;
end;

exec updateUniversity @v_UID = 4,@v_name = 'Oxford University',@v_chancellor = 'Thalapathy Vijay';

create proc deleteUniversity
@UID int
as 
begin
delete from University
WHERE UID =@UID;
END;

EXEC deleteUniversity @UID = 3;

select * from	University


create table College(
CID int primary key,
University int foreign key(University) references University(UID),
Dean int foreign key(Dean) references Dean(DeanID),
Name varchar(50)
);

CREATE  proc insertCollege
@CID int ,
@University int,
@Dean int,
@Name varchar(50)
as
begin
insert into College(CID,University,Dean,Name)values(@CID,@University,@Dean,@Name);
End;

exec insertCollege @CID =1,@University = 1,@Dean = 1,@Name = 'College of Engieering';
exec insertCollege @CID =2,@University = 2,@Dean = 2,@Name = 'Bachelors of technology';


create proc updateCollege 
@CID int,
@University int,
@Dean int,
@Name varchar(50)
as
begin
update College
set University = @University,
Dean = @Dean,
Name = @Name
where CID =@CID
end;

exec updateCollege @CID = 2,@University = 2,@Dean = 2,@Name = 'Bachelors of IT';

create proc deleteCollege
@CID int 
as
begin
delete from College
where CID = @CID
END;

EXEC deleteCollege @CID = 2;

select * from College


create table Dean(
DeanID int primary key,
Name varchar(50),
DateOfBirth datetime
);

create proc InsertDean
@DeanID int,
@Name varchar(50),
@DateOfBirth datetime
as
begin 
insert into Dean values(@DeanID,@Name,@DateOfBirth)
end;
exec InsertDean @DeanID = 1,@Name = 'DR.Smith',@DateOfBirth = '1977-06-15';
exec InsertDean @DeanID = 2,@Name = 'DR.Sharoon',@DateOfBirth = '1987-09-12';

CREATE proc updateDean
@DeanID int,
@Name varchar(50),
@DateOfBirth datetime
as begin
update Dean
set Name = @Name,
DateOfBirth = @DateOfBirth
where DeanID = @DeanID
end;

exec updateDean @DeanID =  1,@Name = 'Dr.Sajith',@DateOfBirth = '1987-09-12';
select * from Dean

create proc deleteDean
@DeanID  int
as
begin
delete from Dean
where DeanID = @DeanID
end;
exec deleteDean @DeanID = 2;


create table Department(
DID int primary key,
College int foreign key(College) references College(CID),
Name varchar(50)
);

create proc InsertDepartment
@DID int,
@College int,
@Name varchar (50)
as
begin
insert into Department values (@DID,@College,@Name)
end;

exec InsertDepartment @DID = 100,@College= 1,@Name = 'Computer Science';
exec InsertDepartment @DID = 101,@College = 2,@Name = 'Computer Appplication';

CREATE proc updateDepartment
@DID int ,
@College int ,
@Name varchar(50)
as begin
update Department
set College = @College,
Name = @Name
where DID= @DID
end;

exec updateDepartment @DID = 101,@College = 2,@Name = 'Computer information';

Create proc deleteDepartment
@DID int
as
begin
delete from Department
where DID = @DID 
end;

exec deleteDepartment @DID = '101';

----Q2
create proc GetComputer_ScienceStudents
as
begin
select s.StudentID ,
s.Name as StudentName,
s.DateofEnrollment,
s.TelephoneNumber,
d.Name as DepartmentName,
c.Name as CollegeName
from Student s
inner join Department d
on s.Department = d.DID
INNER JOIN College c
on d.College = c.CID
WHERE d.Name = 'Computer Science';
end;

exec GetComputer_ScienceStudents;

select * from Department

create table Professor(
PID int primary key,
Department int foreign key(Department) references Department(DID),
Name varchar(50)
);

create proc InsertProffesor
@PID int ,
@Department int,
@Name varchar(50)
as
begin
insert into Professor values(@PID,@Department,@Name)
end;

exec InsertProffesor @PID = 111,@Department = 100,@Name = 'P.Mathews';
exec InsertProffesor @PID = 112,@Department = 101,@Name = 'S.Krishnakumar';

create proc updateProffesor
@PID INT,
@Department int,
@Name varchar(50)
as
begin
update Professor
set Department = @Department,
Name = @Name
where PID = @PID
end;

exec updateProffesor @PID =  111,@Department = 100,@Name = 'M.Mathew Thomas';

create Procedure deleteProffesor
@PID int
as
begin 
delete from Professor
where PID =  @PID
END;

exec deleteProffesor @PID = 112;
select * from Professor


create table Course(
CourseID int primary key,
Department int foreign key(Department) references Department(DID),
Name varchar(60)
);

create proc InsertCourse
@CourseID int,
@Department int,
@Name varchar(60)
as
begin
insert into Course values(@CourseID,@Department,@Name)
END;

exec InsertCourse @CourseID = 555,@Department = 100,@Name = 'B.TECH';
exec InsertCourse @CourseID = 666,@Department = 101,@Name = 'Bsc.ComputerScience';

create proc updateCourse
@CourseID int,
@Department int,
@Name varchar(60)
as
begin
update Course
set Department = @Department,
Name = @Name
where CourseID = @CourseID
end;
exec updateCourse @CourseID = 666,@Department = 101,@Name = 'BSC.ComputerApplication';

create proc deleteCourse
@CourseID int
as
begin
delete from Course
where CourseID = @CourseID
end;
exec deleteCourse @CourseID = 666;

select * from Course


create table Subject(
SubjectID int primary key,
Course int foreign key(Course) references Course(CourseID),
Professor int foreign key(Professor) references Professor(PID),
Name varchar(50)
);

create Proc InsertSubject
@SubjectID int,
@Course int,
@Proffesor int,
@Name varchar(50)
as
begin
insert into Subject values(@SubjectID,@Course,@Proffesor,@Name)
end;

exec InsertSubject @SubjectID = 909,@Course = 555,@Proffesor = 111,@Name = 'DBMS';
exec InsertSubject @SubjectID = 808,@Course	= 666,@Proffesor = 112,@Name = 'C Proggramming';

create proc updateSubject
@SubjectID int,
@Course INT,
@Proffesor int,
@Name varchar(50)
as
begin
update Subject
set Course = @Course,
@Proffesor = @Proffesor,
Name = @Name
where SubjectID = @SubjectID
end;

exec updateSubject @SubjectID = 808,@Course = 666,@Proffesor = 112,@Name = 'Python';

select * from Subject

create table Student(
StudentID int primary key,
Department int foreign key(Department) references Department(DID),
Name varchar(50),
DateofEnrollment smalldatetime,
TelephoneNumber varchar(60)
);

create proc InsertStudents
@StudentID int,
@Department int,
@Name varchar(50),
@DateofEnrollment smalldatetime,
@TelephoneNumber varchar(60)
as 
begin
insert into Student values(@StudentID,@Department,@Name,@DateofEnrollment,@TelephoneNumber)
end;

exec InsertStudents @StudentID = 01,@Department = 100,@Name ='Junaidh',@DateofEnrollment = '2024-08-11',@TelephoneNumber = '555-1234567';
exec InsertStudents @StudentID = 02,@Department = 101,@Name ='Charlie',@DateofEnrollment = '2024-02-12',@TelephoneNumber = '543-7654321';

create proc updateStudent
@StudentID INT,
@Department int,
@Name varchar(50),
@DateofEnrollment smalldatetime,
@TelephoneNumber varchar(50)
as
begin
update Student
set Department = @Department,
Name = @Name,
DateofEnrollment = @DateofEnrollment,
TelephoneNumber = @TelephoneNumber
where StudentID = @StudentID
end;

exec updateStudent @StudentID = 02,@Department = 101,@Name = 'Michael',@DateofEnrollment = '2024-02-12',@TelephoneNumber = '543-7654123';
select * from Student

create proc deleteStudent
@StudentID int
as
begin
delete from Student
where StudentID  = @StudentID
end;
exec deleteStudent @StudentID = 02;


create table Student_Registration(
Student int foreign key(Student) references Student(StudentID),
Subject int foreign key(Subject) references Subject(SubjectID)
);

create Proc InsertStudent_Registration
@Student int,
@Subject int
as
begin
insert into Student_Registration values(@Student,@Subject)
end;

exec InsertStudent_Registration @Student = 01,@Subject = 909;
exec InsertStudent_Registration @Student = 02,@Subject = 808;

create proc updateStudent_Reg
@Student int,
@Subject int
as
begin
update Student_Registration
set Subject = @Subject
where Student = @Student
end;
exec updateStudent_Reg @Student =02,@Subject = 809;


--q3 UDF's AutoIncremet.

CREATE FUNCTION dbo.GetNextUniversityID()
RETURNS INT
AS
BEGIN
    DECLARE @NextID INT;

    SELECT @NextID = ISNULL(MAX(UID), 0) + 1
    FROM University;

    RETURN @NextID;
END;
GO


CREATE OR ALTER PROCEDURE University_Insert
    @v_name VARCHAR(40),
    @v_chancellor VARCHAR(40)
AS
BEGIN
    INSERT INTO University (UID, Name, Chancellor)
    VALUES (
        dbo.GetNextUniversityID(),
        @v_name,
        @v_chancellor
    );
END;
GO


EXEC University_Insert 'Malana University', 'Joseph Vijay';
EXEC University_Insert 'Cambridge University', 'Alice Wonderland';

select * from University

CREATE FUNCTION dbo.GetNextCollegeID()
RETURNS INT
AS
BEGIN
    DECLARE @NextID INT;

    SELECT @NextID = ISNULL(MAX(CID), 0) + 1
    FROM College;

    RETURN @NextID;
END;
GO

CREATE OR ALTER PROCEDURE insertCollege
    @University INT,
    @Dean INT,
    @Name VARCHAR(50)
AS
BEGIN
    INSERT INTO College (CID, University, Dean, Name)
    VALUES (
        dbo.GetNextCollegeID(),
        @University,
        @Dean,
        @Name
    );
END;
GO

EXEC insertCollege @University = 1, @Dean = 1, @Name = 'College of Engineering';
EXEC insertCollege @University = 2, @Dean = 2, @Name = 'Bachelors of Technology';

select * from College

create function dbo.GetNextDeanID()
returns INT 
AS
BEGIN
DECLARE @NextID int ;
select @NextID = isnull(max(DeanID),0)+1
from Dean;
return @NextID;
end;
go

create or alter procedure InsertDean
@Name varchar(50),
@DateOfBirth datetime
as
begin
insert into Dean values (dbo.GetNextDeanID(),@Name,@DateOfBirth);
end;
go

EXEC InsertDean @Name = 'DR.Smith', @DateOfBirth = '1977-06-15';
EXEC InsertDean @Name = 'DR.Sharoon', @DateOfBirth = '1987-09-12';

select * from Dean


CREATE FUNCTION dbo.fn_CollegeDeanUniversity()
RETURNS TABLE
AS
RETURN
(
    SELECT
        c.CID,
        c.Name AS CollegeName,
        d.Name AS DeanName,
        u.Name AS UniversityName
    FROM College c
    INNER JOIN Dean d
        ON c.Dean = d.DeanID
    INNER JOIN University u
        ON c.University = u.UID
);
GO


SELECT * FROM dbo.fn_CollegeDeanUniversity();


create function dbo.GenerateCollegeCode()
returns varchar(50)
as
begin
declare @NextNumber INT ;
declare @CollegeCode varchar(50);

select  @NextNumber = isnull(max(CID),0)+1
FROM College;

set @CollegeCode = 'COL'+RIGHT('00000'+cast(@NextNumber as varchar),5);

return @CollegeCode;
end;
go

select dbo.GenerateCollegeCode();


create function dbo.GetCollegesUnderCambridge()
returns table
as
return
(
select
C.CID,
C.Name as CollegeName
from College C
join University U
on C.University = U.UID
where U.Name = 'Cambridge University'
);
go

select * from dbo.GetCollegesUnderCambridge();

