use Northwind
Select EmployeeID,FirstName,BirthDate ,Convert(nvarchar,BirthDate,102) as ConvertedDOB
from Employees

Select Convert(Varchar(10),GEtDAte(),101)
Select GEtdate()
Select Cast(GETDATE() as Date)
Select Convert(Date,GetDAte())

--create function---
Create function Age(@DOB Date )
Returns INT 
As
Begin
	Declare @Age INT
	Set @Age=DATEDIFF(Year, @DOB ,Getdate())
		-CASE WHEN (MONTH(@DOB)>Month(GETDATE())) or (MONTH(@DOB)=Month(GETDATE())
		 ANd DAY(@DOB) > DAY(GETDATE())) then 1 else 0 END
	Return @Age
END


select Northwind.dbo.Age('2022/7/30')

---pass column as parameter to use scalar function
Select FirstName,LastName,dbo.Age(BirthDate)as Age
from Employees

Select FirstName,LastName,dbo.Age(BirthDate)as Age
from Employees
where dbo.Age(Birthdate)>65

