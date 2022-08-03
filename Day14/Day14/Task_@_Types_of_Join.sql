create table Task_Employee
(ID int  primary key,
Name varchar(20) ,
Designation varchar(20) ,
Location varchar(10) 
,
Salary int )
Alter table Task_Employee alter column Designation Varchar(50)
Alter table Task_Employee alter column Name Varchar(50)

Insert Task_Employee values(1,'Mohit','Software Developier','Nagpur',25000)
select *
from Task_Employee
Insert Task_Employee values(2,'Sourabh','Software Developer','Nagpur',30000)
Insert Task_Employee values(3,'Aashu','Associate S. Developer','Nagpur',20000)


Insert Task_Employee values(4,'Anshul','Software Developer','Noida',35000)
Insert Task_Employee values(5,'Gautam','Software Developer','Pune',28000)
Insert Task_Employee values(6,'Samar','Associate S. Developer','Pune',30000)
Insert Task_Employee values(7,'Sukanya','Testing Engineer','Nagpur',30000)
Insert Task_Employee values(8,'Kavya','Testing Engineeer','Noida',42000)
Insert Task_Employee values(9,'Shrishti','Data Analyst','Banglore',40000)
Insert Task_Employee values(10,'Anii','Data Analyst','Banglore',39000)
select *
from Task_Employee
Update Task_Employee set Designation='Testing Engineer' where ID=8
Update Task_Employee set project_code=01 where ID=1
Update Task_Employee set project_code=06 where ID=2
Update Task_Employee set project_code=04 where ID=3

Update Task_Employee set project_code=02 where ID=4
Update Task_Employee set project_code=03 where ID=5
Update Task_Employee set project_code=02 where ID=6
Update Task_Employee set project_code=05 where ID=7
Update Task_Employee set project_code=01 where ID=8
Update Task_Employee set project_code=05 where ID=9
Update Task_Employee set project_code=06 where ID=10

select *
from Task_Employee



create table Task_Project(project_ID int primary key ,
project_Name varchar(50) ,
project_Type varchar(40) ,
project_Manager varchar(40))

Insert Task_Project values(01,'Job Portal','E-Commerce'
,'Maninder Bawa')
Insert Task_Project values(02,'GL Quora','App Development'
,'S.K Roy')
Insert Task_Project values(03,'Security Z++','Cyber Security'
,'Manmohan Singh')
Insert Task_Project values(04,'Food By Choice','App Development'
,'Shreshtha Jain')
Insert Task_Project values(05,'VI Merging','Networking'
,'Loveleen Kaur')
Insert Task_Project values(06,'Sugar Cosmetic','App Development'
,'Shivanya Rathore')
select *
from Task_Project

Alter table Task_Employee Add project_code int


---Types of join-----------
-----1. Inner Join--------------
---- behave same as conditional join or join
-----"Inner Join" or "Join" is same

select E.ID,E.Name,P.project_Name,P.project_Manager
from Task_Employee as E inner join Task_Project as P ON E.project_code=P.project_ID

---Full join---------------
Insert Task_Employee values(11,'Rupali','Intern','Noida',20000,null)
Insert Task_Employee values(12,'Sharda','Intern','Nagpur',20000,null)
Insert Task_Employee values(13,'Ruhani','Intern','Pune',15000,07)
Insert Task_Employee values(14,'Rashmi','TEchnical Staff','Noida',29000,08)
Insert Task_Project values(10,'Tata Nexa','Information Security','Vihaan Malhotra')

------Full Join --------
-------It contain all values which also does nkot match in right table as well as 
------- in left table
select E.ID,E.Name,P.project_Name,P.project_Manager,E.project_code,P.project_ID
from Task_Employee as E full join Task_Project as P On P.project_ID=E.project_code


-----Left Join----------
-----It contains only extra (which are not satisfied condition )tuples of left table, not of Right Table
----------It contain all tuples of left table and matched tuple of right table which satisfies the condition
select E.ID,E.Name,P.project_Name,P.project_Manager,E.project_code,P.project_ID
from Task_Employee as E left join Task_Project as P On P.project_ID=E.project_code



----------Right Join-----------------
----------It contain all tuples of right table and matched tuple of left table which satisfies the condition
select E.ID,E.Name,P.project_Name,P.project_Manager,E.project_code,P.project_ID
from Task_Employee as E Right join Task_Project as P On P.project_ID=E.project_code

-----------Self Join---------------
-----join same two table with condition
-----It Gives the combination of Employee which have same location-----------
select  E1.Name as Partner1 ,E2.Name as Partner2,E1.Location
from Task_Employee as E1, Task_Employee as E2
where E1.ID<>E2.ID and E1.Location=E2.Location
order by E1.Location,E1.Name


-----CROSS JOIN---------
----To find all possible combination without condition
Select E1.Name as Partner1,E2.Name as Partner2,E1.Location as Partner1_Location,E2.Location as Partner2_Location
from Task_Employee as E1,Task_Employee as E2
where E1.ID<>E2.ID
Order by E1.Location,E1.Name


