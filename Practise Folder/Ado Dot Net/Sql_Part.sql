create database Student
create table Student(
Id int not null primary key,
Name nvarchar(50),
Address nvarchar(50),
Age int)

--Procedure--
Create PROCEDURE Insert_User_Data (  
@Para varchar(50)= '',  
@Id int = 0,  
@Name varchar(50)= '',  
@Address varchar(50)= '',  
@Age int = 0  
) AS BEGIN If @Para = 'ADD' Begin Insert into Student(Id,Name, Address, Age)  
values  
(@Id,@Name, @Address, @Age);  
END Else If @Para = 'Get_For_Grid' Begin  
Select  
*  
from  
Student 
END Else If @Para = 'Get_By_Id' Begin  
Select  Name,  Address,  Age  
from  
Student  
where  
Id = @Id;  
END Else If @Para = 'Update' Begin  
Update  
Student  
Set  
Name = @Name,  
Address = @Address,  
Age = @Age  
where  
Id = @Id;  
END Else If @Para = 'Delete' Begin  
Delete from  
Student
where  
Id = @Id;  
END END

select * from Student