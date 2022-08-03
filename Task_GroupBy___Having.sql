use SampleDB
create table Users(user_id int primary key ,
name varchar(20) ,
city varchar(10) ,
earning int 
)
insert Users values(101,'Rohan','Delhi',3000)
insert Users values(102,'Vihaan','Delhi',5000)
insert Users values(103,'Satish','Delhi',3500)
insert Users values(105,'Rohani','Delhi',3060)
insert Users values(107,'Roshan','Delhi',3900)
insert Users values(100,'Riyan','Goa',3000)
insert Users values(112,'Royan','Goa',3010)
insert Users values(119,'Rashmi','Goa',3400)
insert Users values(120,'Rehan','Jaipur',3700)
insert Users values(122,'Siya','Goa',3070)
select * from Users
insert Users values(123,'Rajendra','Jaipur',3700)
insert Users values(129,'Ramesh','Jaipur',3750)
insert Users values(131,'Rihan','Jaipur',3700)
insert Users values(132,'Kavita','Jabalpur',3900)
insert Users values(133,'Karishma','Jabalpur',4900)
insert Users values(139,'Kartik','Jagdalpur',3900)
insert Users values(138,'Komal','Jagdalpur',5900)
insert Users values(142,'Kavita','Indore',3900)
insert Users values(143,'Kavya','Delhi',3900)
insert Users values(144,'Kangana','Indore',7900)
insert Users values(145,'Kavita','Indore',3900)
insert Users values(147,'Kalu','Indore',3800)
insert Users values(148,'Vivan','Indore',8900)


---GroupBy Clauss Use

---using count aggregate function


---Finding the no of users in particular city
select city,count(name)
from Users
group by city

--Finding the count of the distict name of person
select name,count(name)
from Users
group by name

--Finding earning from different cities with the no of users
select city,count(name) ,sum(earning)
from Users
group by city

--GroupBy with Having Clause
--finding the no of users who having name "Kavita"
select name,count(name)
from Users
group by name
Having name='Kavita'

--finding the name of city which have two or more than two users
select city,count(name)
from Users
group By city
having count(name)>=2

--finding the user who have maximum earning in respective city
---usev of max function

select city,max(earning)
from Users
group by city

--similarily minimum earning among diffrent city
select city,min(earning)
from Users
group by city

--finding the minimum earning of user of those city which have minimum earning more than 3500
select city,min(earning)
from Users
group by city
having min(earning)>3500

---using average aggregate function-----------
select city,avg(earning)
from Users
group by city

--with having clause

select city,avg(earning)
from users
group by city
having avg(earning)>=3500






