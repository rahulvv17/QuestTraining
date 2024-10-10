SELECT 
    student.first_name AS student_first_name,
    student.last_name AS student_last_name,
    exam.exam_name AS exam_name,
    marks.mark AS mark
FROM 
    MARKS marks
LEFT JOIN 
    STUDENT student ON marks.student_id = student.student_id
INNER JOIN 
    EXAM exam ON marks.exam_id = exam.exam_id;
