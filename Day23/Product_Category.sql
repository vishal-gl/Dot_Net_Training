create database Product_Category
create table Category(
CategoryId nvarchar(10) primary key,
CategoryName nvarchar(40)
)
create table Product(
PId nvarchar(10) primary key,
PName nvarchar(40),
Price float,

CategoryId nvarchar(10) ,
FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId))

select * from Product

select * from Category
select * from Product where Product.CategoryId='P01'