CREATE TABLE Department1
(
 DeptID int PRIMARY KEY, 
 DeptName varchar(50) NULL,
 Location varchar(100) NULL,
 )
GO
 CREATE TABLE Employees1
(
 EmpID int PRIMARY KEY, 
 Name varchar(50) NULL,
 Salary int NULL, 
 Address varchar(100) NULL,
 DeptID int foreign Key references Department1(DeptID)
) 
--Now Insert data
INSERT INTO Department1(DeptID,DeptName,Location)VALUES(1,'IT','Delhi')
GO
INSERT INTO Employees1(EmpID,Name,Salary,Address,DeptID)VALUES(1,'Mohan',15000,'Delhi',1)
Select * from Employees1
Select * from Department1

Begin Transaction trans
Begin Try
Insert Into Department1(DeptID,DeptName,Location)values(3,'AS','AP')
Insert into Employees1(EmpID,Name,Salary,Address,DeptID)
values(3,'Mohan',16000,'AP',3)
 if @@TRANCOUNT>0
 Begin Commit Transaction trans
 End
End Try
Begin Catch
 print 'Error Occuured'
 if @@TRANCOUNT>0
 Begin Rollback Transaction trans
 end
End Catch

--now select dat to se  transaction affects
Select * from Employees1
Select * from Department1

--Transaction using Save Point----
Begin Try
Insert Into Department1(DeptID,DeptName,Location)values(2,'HR','Delhi')
if @@TRANCOUNT>0
 Begin Save Transaction trans;
 End
Insert Into Department1(DeptID,DeptName,Location)values(3,'Admin','Delhi')
Insert into Employees1(EmpID,Name,Salary,Address,DeptID)values(1,'Mohan',18000,'Delhi',2)
---both Rows cant added because they are violating primary key---
---3 alraedy in dept id and similarly 1 is alraedy in EmpId
if @@TRANCOUNT>0
 Begin Commit Transaction trans
 End
End Try
Begin Catch
 print 'Error Occuured'
 if @@TRANCOUNT>0
 Begin Rollback Transaction trans
 end
End Catch

--Check affecting result---
Select * from Employees1
Select * from Department1
