use MVC_Department

create proc GetEmployee1
@did int
As
Begin
Select e.Name,e.Gender,e.City,e.Salary,e.DId from Departments as d inner join Employee_Table as e on e.DId=@did;
End
