create table dept
(ID int Primary key Identity(1,1),
DepartmentName nvarchar(50) Not null
)
Alter table temployee add constraint emp_Depart_FK
foreign key(emp_no) references dept(ID)

select * from emp where bsal>4000 and dept_no=10

create table Employee_Table
( EmpNo int not null ,
EName varchar(50) null ,
Job varchar(50) null ,
MGR int null ,
HireDate datetime null ,
Sal int null ,
Comm int null ,
DeptNo int null
)
--Insert
Insert Employee_Table values(1,'Shardha','Trainer',2,'11/07/2022',45000,45,1)
Insert Employee_Table values(2,'Shalini','SDET',3,'12/07/2022',46000,42,2)
Insert Employee_Table values(3,'Shanya','Trainer',6,'11/07/2022',45000,43,3)
Insert Employee_Table values(4,'Savita','Teacher',1,'11/07/2022',4700,44,4)
Insert Employee_Table values(5,'Sonu','Tutor',4,'09/07/2022',44000,41,5)

select * from Employee_Table

--IN=it sis used for evalauating multilple values

select * from Employee_Table where DeptNo in (1,4)
select * from Employee_Table where Job in('Trainer','Teacher')



--LIKE ==> used for pattern matcchib
--% --.matches 0 0r n character
-- _ underscore --.matches the single character
select * from Employee_Table where EName like '%S'

select * from Employee_Table where EName like 'S%'
select * from Employee_Table where EName like '_h%'

--whenever we use % or _ ,alaways ensure that it is preceded by the word 'like'
--ex--- list the employee whose name is having 'o' as second character

select * from Employee_Table where EName like '_o'

--2nd ex list the employee whose name is having  atleast oo
select * from Employee_Table where EName like 'oo_%'

select * from Employee_Table where Job like '_____'

select * from Employee_Table where EName like'____'


--Between Operator => used for searching based on range of values

--1 list the employess whos esal is between 40000 and 48000
select * from Employee_Table where Sal Between 40000 and 48000

--Is Operator is used to compare NULLS
--List the emps where commission is null

select * from Employee_Table where Comm is Null

select * from Employee_Table where MGR is NULl



