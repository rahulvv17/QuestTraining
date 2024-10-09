-- 1. Select students where class is 1 or 3
SELECT id, name, class FROM students WHERE class IN (1, 3);

-- 2. Select students ordered by name in ascending order
SELECT id, name, class FROM students ORDER BY NAME ASC;

-- 3. Select students ordered by name in descending order
SELECT id, name, class FROM students ORDER BY NAME DESC;

-- 4. Select with column aliasing (full_name for name and grade for class)
SELECT id, name AS full_name, class AS grade FROM students;

-- 5. Group by class and count the number of students in each class
SELECT class, COUNT(id) FROM students GROUP BY class;

-- 6. Group by class and count the number of students with an alias
SELECT class, COUNT(id) AS count_of_students FROM students GROUP BY class;

-- 7. Group by class and count the number of students, then filter where count < 5
SELECT class, COUNT(id) AS [count] FROM students GROUP BY class HAVING count(id) < 5;

-- 8. Select the top 5 students
SELECT TOP 5 id, name, class FROM students;

-- 9. Select students with pagination (skip first 5 rows and fetch the next 3)
SELECT id, name, class FROM students
ORDER BY id
OFFSET 5 ROWS
FETCH NEXT 3 ROWS ONLY;

