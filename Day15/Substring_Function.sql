---Query using Substring,CharIndex and Len Function

select SUBSTRING(
'john@bbb.com',
(
select Charindex('@','John@bbb.com') + 1),

(
select Len('john@bbb.com'))
)

---use of substr(string,start,len)

select SUBSTRING('vishal@123456678',4,13)

----use of charindex(char,string)

select CHARINDEX('@','vishal@123556')
