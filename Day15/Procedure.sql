----Procedure----------
create Procedure spGEtEmployes
As
Begin
select EmployeeID,FirstName,LastName,BirthDate,Title from Employees
End

spGEtEmployes
exec spGEtEmployes

---with parameters
Create Proc spGetEmployeesBYGenderandDepartment
@LastName nvarchar(20) ,
@PostalCode nvarchar(10)
as
begin
select FirstName,@LastName from Employees
where LastName=@LastName and PostalCode=@PostalCode
End

select *
from Employees
create proc spGetEmployeeCountByCountry
@Country nvarchar(15) ,
@EmployeeCount int output
as
begin 
Select @EmployeeCount=Count(Country) from Employees where Country =@Country
End
----execute output stord procedure
Declare @EmployeeTotal int
execute spGetEmployeeCountByCountry 'USA' ,@EmployeeTotal output
Print @EmployeeTotal