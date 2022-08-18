create database Employee

create table Emp_Login(

userName varchar(30) ,
Password varchar(30))

Insert into Emp_Login (userName,Password) values ('Admin','Admin123')

Alter table Employee drop column Eid

 select * from Emp_Login
Create  procedure Emplogin
(
@Usename Varchar (20),
@Password varchar (10)
)
as
Begin
Select COUNT(*)from Emp_Login where userName=@Usename and Password=@Password
End