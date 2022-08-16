create database Enemy
go
create table Student(
Id nvarchar(10) primary key,
Name nvarchar(40),
Age int,
Standard int,
City nvarchar(40),
CId nvarchar(10) ,
FOREIGN KEY (CId) REFERENCES Course(CId))

Select * from Student

create table Course(
CId nvarchar(10) primary key,
CName nvarchar(40),


CTutor nvarchar(40),
CDuration int ,


)
Insert into Course values('C01','Information Security','S.K.Krishna',22)
Insert into Course values('C02','Vedic MAths','Raman Rao',28)
Select * from Course