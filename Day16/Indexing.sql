use SampleDB

select * from Employee
exec sp_helpindex Employee

create clustered index IX_Employee_MGR_Sal
on Employee(MGR Desc,Sal Asc)

create nonclustered index IX_Employee_ENAme
on Employee(EName Asc)

select * from Employee

create Unique NonClustered index UIX_Employee
on Employee(EName asc)

Alter table Employee Add Constraint UQ_Employee_Job Unique(Job)