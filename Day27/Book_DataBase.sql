create Database BookDatabase
create table Book(
Id int not null ,
Name nvarchar(40),
Author nvarchar(40),
Publisher nvarchar(40) ,
Price decimal)

--Procedure---
Create PROCEDURE Insert_User_Data (  
@Para nvarchar(40)= '',  
@Id int = 0,  
@Name nvarchar(40)= '',  
@Author nvarchar(40)= '',  
@Publisher nvarchar(40)='',
@Price decimal=0
) 
AS BEGIN If @Para = 'ADD' Begin Insert into Book(Id,Name, Author, Publisher,Price)  
values  
(@Id,@Name, @Author, @Publisher,@Price);  
END Else If @Para = 'Get_For_Grid' Begin  
Select  
*  
from  
Book
END Else If @Para = 'Get_By_Id' Begin  
Select  Name,Author,Publisher,Price  
from  
Book  
where  
Id = @Id;  
END Else If @Para = 'Update' Begin  
Update  
Book  
Set  
Name = @Name,  
Author = @Author,  
Publisher = @Publisher,
Price=@Price
where  
Id = @Id;  
END Else If @Para = 'Delete' Begin  
Delete from  
Book
where  
Id = @Id;  
END END

Select * from Book
