create database Job

create table Users(
UserID INT identity(1,1) primary key,
UserName nvarchar(100)not null,
Email nvarchar(255)unique not null,
PasswordHash nvarchar(255)not null,
Role nvarchar(50) check(Role IN('JobSeeker','JobProvider','Admin')),
CreatedAt datetime default getdate()
);

create table Jobs(
JobID int identity(1,1)primary key,
JobTitle nvarchar(255) not null,
Description TEXT,
Location nvarchar(255),
Salary DECIMAL(10,2),
JobProviderID int FOREIGN KEY references Users(UserID),
CreateAt datetime default getdate()
);

alter table Users ADD PhoneNumber NVARCHAR(15);

insert into Users values ('John Doe','john1@example.com','hashed Password','JobProvider',GETDATE(),9288883888);
select * from Users

insert into Jobs values('software Engineer','Develop web applications using c# and Blazor','New York',80000,1,GETDATE());
select * from  Jobs

update Jobs set  Salary = 100000 where JobID =1;

DELETE from Jobs where JobID = 1;

select JobTitle,Description,Location,Salary from Jobs where Location = 'New York';

truncate table Jobs;

drop table Jobs;


create table emp(Id int primary key,Name nvarchar(300) not null,Department nvarchar(900) not null,Salary bigint not null);
select * from emp
insert into emp values(1,'junaidh','devops',50000),
(2,'edwin','developer',60000),
(3,'vishnu','S.E',50000),
(4,'joyal','developer',50000);

select Department, count(Id) AS Totalemployees from emp
group by Department
having count(Id)>1;

select Department, COUNT (name)		as TotalEmployees from emp 
where Salary <60000
group by Department having count(name)<=1;
