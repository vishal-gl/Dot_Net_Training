create Table tEmployee(
emp_no int not null ,
emp_name varchar(10) not null,
dept_no int ,
grdae varchar(1) ,
basic_salary numeric(9,2)
)

select * from NewEmployee
--Rename the Table
sp_rename NewEmployee ,emp

select * from emp
sp_rename 'emp.basic_salary' ,'bsal'
sp_rename 'emp.grdae' ,'grade'

--identity is used to update automatically id , it starts from 10 and automatically update by 20 
create table department(dept_no int identity(10,20),
dept_name varchar(20),
location varchar(20)
)
--After column datatype

Alter table emp Alter Column emp_no varchar(5) not null
alter table emp alter column emp_no int not null

--add a column
Alter table emp Add DoT datetime

--Drop a column
Alter table emp drop column DoT

---DML Commands

--Insert
Insert emp values('E001','Ayush','10','A',4500,'11/7/2022')
Insert emp values('E002','Rohan','10','B',4600,'11/7/2022')
Insert emp values('E003','Vishakha','11','C',500,'11/7/2022')
Insert emp values('E004','Aniket','11','A',4900,'11/7/2022')
Insert emp values('E005','Anamika','12','A',4900,'11/7/2022')
select * from emp

--Update--
Update emp set emp_name='Vinod' where emp_no='E003'
Update emp set emp_name='Aniii' where emp_no='E004'
select * from emp

--Department--
Insert department values('CS','Jabalpur')
Insert department values('IT','Jabalpur')
Insert department values('Mechanical','Jabalpur')
Insert department values('Civil','Jabalpur')
Insert department values('IP','Jabalpur')
select * from department
