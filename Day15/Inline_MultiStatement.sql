---Inline function return table

--Create function to get employee table
Create function fnGEtInlineEmployees()
returns Table
as
	return(select * from Employees)

--Now call the above created function
Select * from fnGEtInlineEmployees()
---return a table

--Multi-Statement Inlinement Function
Create function fnGetMultiEmployee()
returns @Emp Table
(
EmployeeID int,
FirstName nvarchar(10) ,
Title nvarchar(30)
)
as
begin
	Insert into @Emp Select e.EmployeeID,e.FirstNAme,e.Title from Employees e;
	--now we can update the title
	update @Emp set Title='Software Developer' where EmployeeID=2;
return
end

--Now call the above function

Select * from fnGetMultiEmployee()


--now again another function---
---Inline Function-------------
Create function fnGetMultiCustomer()
returns @Custo Table
(
CompanyName nvarchar(40),
City nvarchar(15) ,
PostalCode nvarchar(10)
)
as
begin
	Insert into @Custo Select c.CompanyName,c.City,c.PostalCode from Customers c;
	--now we can update the title
	update @Custo set PostalCode='456335' where CompanyName='Ana Trujillo Emparedados y helados';
return
END
 ---call above created function
select *
from fnGetMultiCustomer();
---call table 
select *
from Customers

----create normal inline function
Create function fnGEtInlineCustomers()
returns Table
as
	return(select * from Customers)


----call the inline function---
Select * from fnGEtInlineCustomers()