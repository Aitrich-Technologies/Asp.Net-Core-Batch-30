create database ddl;
create table users(Userid int identity(1,1) primary key, Name nvarchar(100) not null,Email nvarchar(255) not null, Password nvarchar(255) not null, Role nvarchar(60) check(Role in('Jobseeker','Jobprovider','Admin')),CreatedAt DATETIME default getdate());
create table Jobs(Jobid int identity(1,1) primary key,Jobtitle nvarchar(255) not null,Description text,Location nvarchar(255),Salary decimal(10,2),Jobprovider int foreign key references users(userid),CreatedAt Datetime default getdate());
alter table users add Phonenumber nvarchar(15);
drop table Jobs;
truncate table Jobs;
insert into users values('vishnu','vishnu@gmail.com','passwords','Jobprovider',16-12-2025,1234567890);
select * from users;
select * from Jobs;
insert into  Jobs  values('Software Engineer','Develop web applications using C# and Blazor','U.S.A',20000,1,2025-12-24);
insert into Jobs values('.net developer','Develop web applications using C# and Blazor','New York',20000,2,Getdate());
update Jobs set Salary=90000 where Jobid=1;

insert into users values('jane','vishnu@gmail.com','passwords','Jobprovider',GETDATE(),1234567890);
delete from Jobs where Jobid=2;
select Jobtitle,Description,Location,Salary from Jobs where Location = 'U.S.A';


create table Employee(id int identity(1,1),name nvarchar(50),department nvarchar(100),salary decimal(10,2))
insert into Employee values( 'Edwin','Developer',20000),('vishnu','s.e',200000),('Junaidh', 'Developer',250000),('prinitta','s.e',250000),('Clerin','Acc',50000),('Aswin','python',27000);
select * from Employee
select department,count(name)as totalemployees from Employee group by department;
select salary,count(id) as totalemployees  from Employee group by salary having Employee.salary>=250000
select * from Employee
select department,count(name)as totalemployees from Employee where salary >= 25000 group by department having count(name)>=2;
