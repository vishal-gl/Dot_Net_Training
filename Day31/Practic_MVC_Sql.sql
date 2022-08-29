use Practise_MVC

select * from Courses


--To Select all Courses
create proc SelectCourses
as
Begin
Select * from Courses
End

exec SelectCourses

--To delete a course record
create proc DeleteCourse
@cid int
as
Begin
Delete from Courses where CourseId=@cid
End

---To Update the Course
create proc UpdateCourse
@cid int,
@Cname nvarchar(max),
@Tname nvarchar(max),
@Cduration nvarchar(max)
as
Begin
UPDATE Courses SET CourseName=@Cname,TutorName=@Tname,Duration=@Cduration Where CourseId=@cid
END

--To View The Student list
create proc SelectStudent
as
Begin
Select * from Student_Table
End

--To delete the student record
--To delete a course record
create proc DeleteStudent
@id int
as
Begin
Delete from Student_Table where SId=@id
End

---To Update the Student
create proc UpdateStudent
@id int,
@name nvarchar(max),
@address nvarchar(max),
@dob datetime,
@age int,
@cid int,
@email nvarchar(max),
@password nvarchar(max),
@cpassword nvarchar(max)
as
Begin
UPDATE Student_Table SET Name=@name,Address=@address,DOB=@dob,Age=@age,CourseId=@cid,Email=@email,Password=@password,CPassword=@cpassword Where SId=@id
END
                   
        

        