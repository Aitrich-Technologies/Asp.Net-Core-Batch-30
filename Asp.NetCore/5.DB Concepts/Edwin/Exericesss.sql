create database  UniversitySystem
drop database UniversitySystem

create table Univeristy(UID int primary key,Name varchar(20),Chancellor varchar(20))

create table Dean(DeanID int primary key,Name varchar(20),DateOfBirth datetime)

create table College(CID int primary key,Name varchar(20),
Univeristy int Foreign key(Univeristy) references Univeristy(UID)
,Dean int Foreign key(Dean)references Dean(DeanID))

create table Department(DID int primary key,Name varchar(20),
College int foreign key(College) references College(CID))

create table Professor(PID int primary key,Name varchar(20),
Department int Foreign key(Department) references Department(DID))

create table Course(CourseID int primary key,Name varchar(20),
Department int foreign key(Department) references Department(DID))

create table Subjects(SubjectID int primary key,Name varchar(20),
Course int Foreign key (Course) references Course(CourseID),
Professor int foreign key(Professor) references Professor(PID))

create table Student(StudentID int primary key,Name varchar(20),Dateofenrollment smalldatetime,telephoneNumber varchar(20),
Department int foreign key(Department) references Department(DID)) 

create table Student_Registration(Student int foreign key(Student) references Student(StudentID),
Subject int Foreign key(Subject) references Subjects(SubjectID));

select * from Univeristy

CREATE PROC sp_InsertUniversity
@UID int,
@Name VARCHAR(20),
@Chancellor VARCHAR(20)
AS
BEGIN
    INSERT INTO Univeristy
    VALUES ( @UID,@Name, @Chancellor)
END
EXEC sp_InsertUniversity 1,'Cambridge', 'Smith'
exec sp_InsertUniversity 2,'Cambridge University','Alice wonderlanaa';
exec sp_InsertUniversity 3,'Malana University','Thalapathy VetriKONDAN';

drop proc sp_InsertUniversity


CREATE PROC sp_UpdateUniversity
@UID INT,
@Name VARCHAR(20)
AS
BEGIN
    UPDATE Univeristy
    SET Name = @Name
    WHERE UID = @UID
END


drop proc sp_UpdateUniversity

    EXEC sp_UpdateUniversity 1, 'Cambridge University'

create proc deleteUniversity
@UID int
as 
begin
delete from Univeristy
WHERE UID =@UID;
END;

EXEC deleteUniversity @UID = 3;

select * from    Univeristy





CREATE  proc insertCollege
@CID int ,
@University int,
@Dean int,
@Name varchar(50)
as
begin
insert into College(CID,Univeristy,Dean,Name)values(@CID,@University,@Dean,@Name);
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
set Univeristy = @University,
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




