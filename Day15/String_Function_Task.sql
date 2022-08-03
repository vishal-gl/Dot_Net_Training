use Northwind

--Ascii
SELECT CompanyName, ASCII(CompanyName) AS NumCodeOfFirstChar
FROM Customers;

----Char length
SELECT CompanyName, LEN(CompanyName) AS LengthOfName
FROM Customers;

---CONCAT 
SELECT CONCAT('SQL ', 'Tutorial ', 'is ', 'fun!') AS ConcatenatedString;
SELECT CompanyName ,CONCAT(Address, ' ' , PostalCode, ' ', City) AS Address
FROM Customers;

---Concat_WS(separator,expr1,expre2...)
SELECT CONCAT_WS(' -- ', Address, PostalCode, City) AS Address
FROM Customers;

--lower() 
SELECT Lower(CompanyName) AS LowercaseCustomerName
FROM Customers;

--print 3 char from left
SELECT LEFT('SQL Tutorial', 3) AS ExtractString;

--print 4 char from right
SELECT RIGHT('SQL Tutorial', 8) AS ExtractString;

---LTRIM use for remove all blank space from left
SELECT LTRIM('     SQL Tutorial') AS LeftTrimmedString;

---REPLACE(string, replace string, new_string)
SELECT REPLACE('SQL Tutorial', 'SQL', 'HTML');

--Reverse the string
SELECT REVERSE('SQL Tutorial');

--SUBSTRING(string, start, length)
SELECT SUBSTRing(CompanyName, 2, 5) AS ExtractString
FROM Customers;

----remove space from left as well as from right
SELECT TRIM('    SQL Tutorial    ') AS TrimmedString;

