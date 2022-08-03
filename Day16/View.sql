---VIEW---------
create table Employee_Test(Emp_id int identity ,
Emp_name varchar(55) ,
Emp_technology varchar(55) ,
Emp_sal decimal(10,2) ,
Emp_designation varchar(20)
)

--to view detailed inforamtion of the coulumns od table_employement_test
Select * from INFORMATION_SCHEMA.COLUMNS
where TABLE_NAME='Employee_Test'

select * from sys.tables
---to sell all sql server information---
select connection_id,session_id,client_net_address,auth_scheme
from sys.dm_exec_connections

--now Insert data to tables Employee_Test
Insert into Employee_Test values('Amit','PHP',12000,'SE')
Insert into Employee_Test values('Mahesh','Asp.NEt',15000,'TL')
Insert into Employee_Test values('Avin','JAva',22000,'SE')
Insert into Employee_Test values('Manoj','C#',42000,'SDE')

--Now create view on single table Employee_Test
create VIEW vw_Employee_Test
as
select Emp_id,Emp_name,Emp_designation
from Employee_Test

---Query view like as table--
Select * from vw_Employee_Test

-----In the simple view we can insert ,update ,delete data
---- we can only insert data in a simple view
--if we have a primary key and all not null fields in the view 
---insert data to view vw_Employee_Test
insert into vw_Employee_Test(Emp_name,Emp_designation) values ('Shailu','SSE')
Select * from vw_Employee_Test

--Update daata to view vw_Employee_Test
Update vw_Employee_Test set Emp_name='Pawan' where Emp_id=5
--now see the afftected view
select * from vw_Employee_Test

--Delete the data in view
delete from vw_Employee_Test where Emp_id=5
Select * from vw_Employee_Test
select * from Employee_Test