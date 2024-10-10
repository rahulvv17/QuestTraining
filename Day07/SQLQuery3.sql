INSERT INTO STUDENT (first_name, last_name, gender, age, phone_number, email)
VALUES
('John', 'Doe', 'M', 20, '9876543210', 'john.doe@example.com'),
('Emma', 'Watson', 'F', 22, '9876532100', 'emma.watson@example.com'),
('Liam', 'Smith', 'M', 21, '9876541234', 'liam.smith@example.com');

INSERT INTO SUBJECT (subject_name, subject_code)
VALUES
('Mathematics', 'MAT101'),
('Physics', 'PHY101'),
('Computer Science', 'CS101');

INSERT INTO EXAM (exam_name, min_mark, max_mark)
VALUES
('Mid-term Exam', 35, 100),
('Final Exam', 40, 100),
('Quiz', 10, 20);

INSERT INTO MARKS (exam_id, student_id, subject_id, mark)
VALUES
(1, 1, 1, 85),  -- John, Mid-term Exam, Mathematics
(2, 2, 2, 90),  -- Emma, Final Exam, Physics
(3, 3, 3, 18);  -- Liam, Quiz, Computer Science
