-----Scalar Functions----

----USe of Abs Function---
---it give alaways absolute value(positive value always)
select Abs(-345.7)

---use of ceiling function-----
Select Ceiling(15.2)

---use 0f Floor Function----
Select FLOOR(14)
Select Floor(16.9)


-----use of Power(expression,power)

select power(4,-1)--it alaway return value 0
select power(4,2)

---RAND([Seed_Value])
--Returns a random float value betwween 0 and 1
--Rand function takes an optional seed parameter
select Rand(1) ---always return the same value

---if you want to generate a random number between 1 and 100
Select Floor(Rand()*100)


--the folowing query prints 10 random numbers between 1 and 100

Declare @Counter INT
Set @Counter=1
While(@Counter<=10)
Begin
	Print Floor(Rand()*100)
	Set @Counter=@Counter+1
End

--Use of Square function-
select square(9)

---use of sqrt function
select sqrt(81)---it return 9


--Round(numeric_expression,length [ ,function ])
--1. Numeric expression is the number that we want to round to
--2.Length parameter ,specifies the number of digits taht we want tom round .
-----if lengthn is positive number ,rounding is applied to decimal point
-----if length is negative,rounding off is applied to nuber before decimal point

select round(850.556,2)--returns 850.560

---truncate anything after 2 places , after (to the rigjt) the decim al point


select round(850.556,2,1)--return 850.550

select round(850.556,1)--returns 850.600

select round(850.556,1,1)---retruns 850.500