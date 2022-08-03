use SampleDB

create table Student(sid int primary key,
sname varchar(30) ,
sclass varchar(10) ,
scity varchar(40) ,
)

create table Student1(sid int Unique,
sname varchar(30) ,
sclass varchar(10) ,
scity varchar(40) ,
)

Insert Student1 values(1,'Vishal','2','Nagda')
Insert Student1 values(2,'Vishali','3','Nagda')
Insert Student1 values(null,'Vishakha','2','Nagda')
Insert Student1 values(4,'Vikruti','2','Nagda')


create table Empo(e_id Varchar(10) primary key ,
e_name varchar(30) ,
d_id Varchar(10) ,
e_location varchar(30)
)

Insert Empo values('E01', 'Raghav','D01','Pune')
Insert Empo values('E02','Vishal','D02','Nagpur')
Insert Empo values('E03','Ayush','D01','Pune')
Insert Empo values('E04','Vishalika','D02','Nagpur')
Insert Empo Values('E05','Vinayak','D03','Noida')

---Here Did---> also find location ,so it give redundancy
-----Non_prime-->Non prime ----------
--so we have to split the table

---create table 
create table newEmpo(e_id varchar(10) primary key ,
e_name varchar(30) ,
d_id varchar(10)
)
Insert newEmpo values('E01', 'Raghav','D01')
Insert newEmpo values('E02','Vishal','D02')
Insert newEmpo values('E03','Ayush','D01')
Insert newEmpo values('E04','Vishalika','D02')
Insert newEmpo Values('E05','Vinayak','D03')


select e_id,e_name,d_id
from newEmpo as e;

---Another table

create table newDepo(d_id varchar(10) primary key ,
e_location varchar(30)
)

Insert newDepo values('D01','Pune')
Insert newDepo values('D02','Nagpur')


Insert newDepo Values('D03','Noida')
select d_id,e_location
from newDepo as e

select *
from emp



select *
from department


---List the department names that are having atleat 1 emplooyee in it
select e_location
from newDepo
where d_id in (select d_id from Empo group by d_id having count(*)>0)


select *
from Task_Employee
select  *
from department
---lis the department names that are having having 2 employee in it
select e_location
from newDepo
where d_id in (select d_id from Empo group by d_id having count(*)>=2)

---list the department name which are having atleast
select project_Name
from Task_Employee

----display 2nd Maximum salary
select max(salary) from Task_Employee where Salary<(select max(Salary)
from Task_Employee)

----display 3rd maximum salary
select max(Salary) from Task_Employee where Salary<(select max(Salary) from Task_Employee where Salary<(select max(Salary) from Task_Employee))


---list the project who having no employess
select project_Name
from Task_Project
where project_ID not in (select project_code from Task_Employee)


-----