-- sort table by number of employees (high to low)
-- https://www.codewars.com/kata/593ed37c93350098d600001d
SELECT id, ceo, motto, employees 
FROM companies 
ORDER BY employees DESC;