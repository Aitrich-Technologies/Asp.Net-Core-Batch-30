exec sp_renamedb sample,activity
create table Ts_companyMaster(id int, name varchar(30),remarks int)
create table Ts_companygroup(id int, name varchar(30),remarks int)
create  table TS_ItemMaster(id int, name varchar(20),company_id int, group_id int,rate varchar(100), remarks int)
create table TS_Purchse_Header(id int, purchseno int,trnsdate date,total int,remarks int)
create table TS_Purchase_Detail(id int, headerid int, itemid int,qty int,rate int, amount int)
insert into TS_CompanyMaster (id,name,remarks) values (1, 'p&g','')
insert into TS_CompanyMaster (id,name,remarks) values (2,'XENICAL','')
insert into TS_CompanyMaster (id,name,remarks) values (3,'J&J','')
insert into TS_CompanyMaster (id,name,remarks) values (4,'JAC','')

insert into Ts_companygroup (id,name,remarks) values (1,'INHALER','')
insert into Ts_companygroup (id,name,remarks) values (2,'DROPS','')
insert into Ts_companygroup (id,name,remarks) values (3,'POWDER','')
insert into Ts_companygroup (id,name,remarks) values (4,'OINTMENT','')

delete from TS_CompanyMaster  where id=1
delete from Ts_companygroup where name='INHALER'

update TS_CompanyMaster set name='P&G' where id=2
update Employee set EName=(select EName from Employee where EmpNo=2000)

drop table TS_CompanyMaster

select id,name  into Copy_Company from TS_CompanyMaster 
select * into Copy_TS_CompanyMaster  from TS_CompanyMaster 

Alter table Ts_companygroup alter column id bigint

Alter table TS_Purchse_Header add finalamount bigint

exec sp_rename Ts_companygroup,Ts_group

