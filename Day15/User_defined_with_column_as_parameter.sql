use SampleDB
select *
from Task_Employee
Create function fnGetEmpwithJobName(
@Name varchar(50) ,
@Designation varchar(50)
)
returns varchar(100)
as
Begin return (Select  @Name +' - '+@Designation);
end
select *
From Task_Employee
--------calling the ab
select dbo.fnGetEmpwithJobName(Name,Designation) as DETail ,
Salary from Task_Employee


select SUBSTRING(
'john@bbb.com',
(
select Charindex('@','John@bbb.com') + 1),

(
select Len('john@bbb.com'))
)


