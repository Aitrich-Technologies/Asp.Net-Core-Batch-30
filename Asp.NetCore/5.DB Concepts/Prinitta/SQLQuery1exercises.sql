create database exercises

create table Universitys (UID int primary key, Name varchar(20), Chancellor varchar(20))
create table Collages(CID int primary key, Name varchar(20), DeanID int foreign key (DeanID) references Deanss(DeanID), UID int foreign key (UID) references Universitys(UID))
create table Deanss(DeanID int primary key, Name varchar(20), DateOfBirth datetime)
create table Depart(DID int primary key, Name varchar(20), CID int foreign key(CID) references Collages(CID))
create table Professorss(PID int primary key, Name varchar(20), DID int foreign key (DID) references Depart(DID))
create table Cours(CourseID int primary key, Name varchar(20), DID int foreign key (DID) references Depart(DID))
create table Sub(SubjectID int primary key, Name varchar(20), CourseID int foreign key (CourseID) references Cours(CourseID), PID int foreign key(PID) references Professorss(PID))
create table Stud(StudentID int primary key, Name varchar(20), DateofEnrollment smalldatetime, TelephoneNumber varchar(20), DID int foreign key(DID) references Depart(DID))
create table studentreg(StudentID int foreign key(StudentID) references Stud(StudentID),SubjectID int foreign key(SubjectID) references Sub(SubjectID))

create proc InsertUniversitys 
(
@UID int,
@Name varchar(20),
@Chancellor varchar(20)
)
AS
BEGIN
insert into Universitys values(@UID,@Name,@Chancellor);
END;
EXEC InsertUniversitys 1,'kerala university','Ramesh';
EXEC InsertUniversitys 2,'Calicut University','Priya';

select * from Universitys;

create proc UpdateUniversitys
(
@UID int,
@Name varchar(20),
@Chancellor varchar(20)
)
AS
BEGIN
Update Universitys
set 
Name=@Name,
Chancellor=@Chancellor
where UID=@UID;
END
EXEC UpdateUniversitys 1,'Kerala university','Dr Mohan';

create proc DeleteUniversitys
(
@UID int 
)
AS
BEGIN
Delete from Universitys where UID=@UID;
END;

EXEC DeleteUniversitys 1;





