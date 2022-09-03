use Task_PC

create proc SelectCategory
as
Begin
Select * from Categories
End

--To delete a category record
create proc DeleteCourse
@cid int
as
Begin
Delete from Categories where CId=@cid
End

---To Update the Category
create proc EditCategory
@cid int,
@name nvarchar(max)
as
Begin
UPDATE Categories SET CategoryName=@name Where CId=@cid
END

---To Insert the Product
create proc InsertProduct1

@name nvarchar(max),
@price real ,
@cid int
as
Begin
Insert into Products(Name,Price,CId) values (@name,@price,@cid)
END

---To Select product
create proc SelectProduct1
as
Begin
Select * from Products
End

create proc DeleteProduct
@id int
as
Begin
Delete from Products where PId=@id
End

---To Update the Product
create proc EditProduct
@id int,
@price real,
@cid int,
@name nvarchar(max)
as
Begin
UPDATE Products SET Name=@name,Price=@price,CId=@cid Where PId=@id
END

select * from Categories
