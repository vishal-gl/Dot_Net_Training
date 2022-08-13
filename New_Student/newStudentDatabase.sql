create database newStudent
create table Student(
Id nvarchar(10) primary key,
Name nvarchar(40),
Age int,
Standard int,
City nvarchar(40)
)
Alter Table Student add  CId nvarchar(10)
select * from Student
create table Course(
CId nvarchar(10) primary key,
CName nvarchar(40),
CTutor nvarchar(40),
)
Insert into Course values('C01','Data Science','S.K.Rao')
Insert into Course values('C02','Analytics','S.N.Rao')
select * from Course
select * from Student
Select Student.* ,Course.CName,Course.CTutor from Student  Inner Join Course on Student.CId=Course.CId 