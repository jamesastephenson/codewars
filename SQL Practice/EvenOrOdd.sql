--https://www.codewars.com/kata/53da3dbb4a5168369a0000fe/sql
--Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.

SELECT 
  CASE 
    WHEN number % 2 = 0 THEN 'Even' 
    ELSE 'Odd'
  END
AS is_even 
FROM numbers;