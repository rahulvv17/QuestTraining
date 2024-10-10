SELECT 
    marks.mark_id AS mark_id,
    marks.mark AS mark,
    student.student_id AS student_id,
    student.first_name AS first_name,
    student.last_name AS last_name,
    subject.subject_id AS subject_id,
    subject.subject_name AS subject_name,
    exam.exam_id AS exam_id,
    exam.exam_name AS exam_name
FROM 
    MARKS marks
INNER JOIN 
    STUDENT student ON marks.student_id = student.student_id
INNER JOIN 
    SUBJECT subject ON marks.subject_id = subject.subject_id
INNER JOIN 
    EXAM exam ON marks.exam_id = exam.exam_id;
