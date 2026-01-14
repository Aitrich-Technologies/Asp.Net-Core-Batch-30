create database ExerciseTSQL

create table University(UID int primary key,Name varchar(20),Chancellor varchar(20));


create table Deans(DeanID int primary key,Name varchar(20),Dateofbirth datetime);

create table College(CID int primary key,Name varchar(20),UID int,foreign key(UID) references University(UID),
DeanID int,foreign key(DeanID) references Deans(DeanID));

create table Department(DID int primary key,Name varchar(20),CID int,foreign key(CID) references College(CID));

create table Professor(PID int primary key,Name varchar(20),DID int,foreign key(DID) references Department(DID));

create table Cource(CourceID int primary key,Name varchar(20),DID int,foreign key(DID) references Department(DID));

create table subject(subjectID int primary key,Name varchar(20),CourceID int,foreign key(CourceID) references Cource
(CourceID),PID int,foreign key(PID) references professor(PID));

create table student(studentID int primary key,Name varchar(20),DateofEnrollment smallDateTime,Telephonenumber varchar(20),
DID int,foreign key(DID) references Department(DID));


create table student_Registration(studentID int,foreign key(studentID) references student(studentID),subjectID int,
foreign key(subjectID) references subject(subjectId));



create procedure insertUniversity
(
@UID int,
@Name varchar(20),
@Chancellor varchar(20)

)
AS
Begin
insert into University(UID,Name,Chancellor)
values(@UID,@Name,@Chancellor)

End;
Go

EXEC insertUniversity 1,'kerala university','Ramesh';
EXEC insertUniversity 2,'calicut University','clerin paul';
EXEC insertUniversity 3,'Bharath university','peter';

select * from University;


create procedure UpdateUniversity
(
@UID int,
@Name varchar(20),
@Chancellor varchar(20)
)
AS
Begin
update University
set Name=@Name,
Chancellor=@Chancellor
where UID=@UID;
End;
Go

EXEC UpdateUniversity 1,'Anna UNiversity','DR. Ramesh';
EXEC UpdateUniversity 2,'calicut university','DR.clerin paul';
EXEC UpdateUniversity 3,'Bharath university','DR.peter john';
EXEC UpdateUniversity 4,'cambridge university','DR.Manual';
EXEC UpdateUniversity 5,'cambridge university','DR.Anu';



create procedure DeleteUniversity
(
@UID int
)
AS 
Begin
Delete from University
where UID =@UID
END;
Go

EXEC DeleteUniversity 1;




create procedure  insertDeans
(
@DeanID int,
@Name varchar(20),
@Dateofbirth datetime

)
AS
Begin
insert into Deans(DeanID,Name,Dateofbirth)
values(@DeanID,@Name,@Dateofbirth)
End;
Go


EXEC insertDeans 1,'Ashwin','2026-08-11';
EXEC insertDeans 2,'Alwin','2026-04-06';
EXEC insertDeans 3,'Arjun','2026-02-03';

select * from Deans;


create procedure UpdateDeans
(
@DeanID int,
@Name varchar(20),
@Dateofbirth Datetime
)
AS
Begin
update  Deans
set Name=@Name,
Dateofbirth=@Dateofbirth
where DeanID=@DeanID
END;
GO

EXEC UpdateDeans 1,'ashwin shaju','2026-08-11';
EXEC UpdateDeans 2,'Alwin saji','2026-04-01';


create procedure DeleteDeans
(
@DeanID int
)
AS
Begin
Delete from Deans
where DeanID=@DeanID;
End;
Go

EXEC DeleteDeans 1;


create procedure insertCollege
(
@CID int,
@Name varchar(20),
@UID int,
@DeanID int
)
AS
Begin
insert into College(CID,Name,UID,DeanID)
values(@CID,@Name,@UID,@DeanID)
End;
Go


EXEC insertCollege 1,'Ammu',2,2;
EXEC insertCollege 2,'Ashok',3,3;


select * from  College;


create procedure updateCollege
(
@CID int,
@Name varchar(20),
@UID int,
@DeanID int
)
AS
Begin
update College
set Name=@Name,
UID=@UID,
DeanID=@DeanID
where CID=@CID
End;
Go

EXEC updateCollege 1,'Ammu kp',2,3;
EXEC updateCollege 2,'Ashok kk',3,3;

create procedure DeleteCollege
(
@CID int
)
AS
Begin
Delete from College 
where CID=@CID
End;
Go

EXEC DeleteCollege 1;


create procedure insertDepartment
(
@DID int,
@Name varchar(20),
@CID int
)
AS
Begin
insert into Department(DID,Name,CID)
values(@DID,@Name,@CID)
End;
Go


EXEC insertDepartment 1,'clince',2;

select * from Department;

create procedure UpdateDepartment
(
@DID int,
@Name varchar(20),
@CID int
)
AS
Begin
update Department
set Name =@Name,
CID=@CID
where DID=@DID
End;
Go


EXEC UpdateDepartment 1,'clince paul',2;



create procedure insertProfessor
(
@PID int,
@Name varchar(20),
@DID int
)
AS
Begin
insert into Professor(PID,Name,DID)
values(@PID,@Name,@DID)
END;
GO

EXEC insertProfessor 1,'manoj',1;

select * from Professor;


create procedure updateProfessor
(
@PID int,
@Name varchar(20),
@DID int
)
AS
Begin
update Professor
set Name=@Name,
DID=@DID
where PID=@PID;
End;
Go

EXEC updateProfessor 1,'Manjoj Rameshwar',1;


create procedure insertCource
(
@CourceID int,
@Name varchar(20),
@DID int
)
As
Begin
insert into Cource(CourceID,Name,DID)
values(@CourceID,@Name,@DID)
End;
Go

EXEC insertCource 1,'mukesh',1;


create procedure updateCource
(
@CourceID int,
@Name varchar(20),
@DID int
)
AS
Begin
update Cource
set Name=@Name,
DID=@DID
where CourceID=@CourceID
End;
Go

EXEC updateCource 1,'Mukesh Baiju',1;

select * from Cource


create procedure insertsubject
(
@subjectID int,
@Name varchar(20),
@CourceID int,
@PID int
)
AS
Begin
insert into subject(subjectID,Name,CourceID,PID)
values(@subjectID,@Name,@CourceID,@PID)
End;
Go

EXEC insertsubject 1,'Mareena',1,1;

select * from subject;

create procedure Updatesubject
(
@subjectID int,
@Name varchar(20),
@CourceID int,
@PID int
)
AS
Begin
update subject
set Name=@Name,
CourceID=@CourceID,
PID =@PID
where subjectID=@subjectID;
End;
Go

EXEC Updatesubject 1,'lachu',1,1

EXEC Updatesubject 1,'ADV.lachu',1,1;


create procedure insertstudent
(
@studentID int,
@Name varchar(20),
@DateofEnrollment smallDateTime,
@Telephonenumber varchar(20),
@DID int
)
AS
Begin
insert into student(studentID,Name,DateofEnrollment,Telephonenumber,DID)
values(@studentID,@Name,@DateofEnrollment,@Telephonenumber,@DID)
End;
Go


EXEC insertstudent 1,'Alweena','2026-01-06',7865432190,1

select * from student;

create procedure updatestudent
(
@studentID int,
@Name varchar(20),
@DateofEnrollment smallDateTime,
@Telephonenumber varchar(20),
@DID int
)
AS
Begin
update student
set Name=@Name,
DateofEnrollment=@DateofEnrollment,
Telephonenumber=@Telephonenumber,
DID=@DID
where studentID=@studentID
End;
Go


EXEC updatestudent 1,'Anashwara','2026-09-13',234567890,1;



create procedure insertstudent_Registration
(
@studentID int,
@subjectID int
)
AS
Begin
insert into student_Registration(studentID,subjectID)
values(@studentID,@subjectID)
End;
Go

EXEC insertstudent_Registration 1,1;

select * from student_Registration;



CREATE PROCEDURE GetComputerScienceDepartment
AS
BEGIN
    SELECT 
        s.StudentID,
        s.Name,
        s.Telephonenumber
    FROM student s
    JOIN Department d
        ON s.DID = d.DID
    WHERE d.Name = 'Computer Science';
END;
GO



create function dbo.NextId
(
@TableName varchar(100),
@ColumnName varchar(100)
)
Returns INT
As
Begin
declare @NextID int;
declare @SQL Nvarchar(200);

set @sql=
'select @NextID isNUll(Max('+@ColumnName + '),0)+1 from' +@TableName;
Exec sp_executesql
@SQl,
N'@NextID int Output',
@NextID output;
Return @NextID;
END;
GO

SELECT dbo.NextID('University','UID');


CREATE FUNCTION dbo.GetDeanUniversityDetails()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        C.Name AS CollegeName,
        D.Name AS DeanName,
        U.Name AS UniversityName
    FROM College C
    JOIN Deans D 
        ON C.DeanID = D.DeanID
    JOIN University U 
        ON C.UID = U.UID
);
GO



SELECT * FROM dbo.GetDeanUniversityDetails();




CREATE FUNCTION dbo.GenerateCollegeCode()
RETURNS VARCHAR(10)
AS
BEGIN
    DECLARE @NextNumber INT;
    DECLARE @CollegeCode VARCHAR(10);

    
    SELECT @NextNumber = ISNULL(MAX(CID), 0) + 1
    FROM College;

    
    SET @CollegeCode = 'COL' + RIGHT('00000' + CAST(@NextNumber AS VARCHAR), 5);

    RETURN @CollegeCode;
END;
GO


SELECT dbo.GenerateCollegeCode();


CREATE FUNCTION dbo.GetCollegesUnderCambridge()
RETURNS TABLE
AS
RETURN
(
    SELECT 
        C.CID,
        C.Name AS CollegeName
    FROM College C
    JOIN University U
        ON C.UID = U.UID
    WHERE U.Name = 'cambridge university'
);
GO


SELECT * FROM dbo.GetCollegesUnderCambridge();


































