create database EmployeeLinq
use Employee

create table Employee(
Id nvarchar(10) ,
Name nvarchar(40) ,
Salary float,
Dept_Id nvarchar(10))
select* from Employee