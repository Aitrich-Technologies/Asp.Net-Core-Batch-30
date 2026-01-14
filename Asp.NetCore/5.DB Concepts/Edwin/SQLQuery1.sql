use sample
create table student(id int primary key,name varchar(30))
alter table student add rollno int;
exec sp_rename 'student','students'

