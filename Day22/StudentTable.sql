create database Enemy
go
create table Student(
Id nvarchar(10) primary key,
Name nvarchar(40),
Age int,
Standard int,
City nvarchar(40),
CId nvarchar(10)
)
Select * from Student