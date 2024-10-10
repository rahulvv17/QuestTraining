CREATE TABLE STUDENT (
    student_id INT PRIMARY KEY IDENTITY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    gender CHAR(1),
    age INT,
    phone_number VARCHAR(15),
    email VARCHAR(100)
);


CREATE TABLE SUBJECT (
    subject_id INT PRIMARY KEY IDENTITY,
    subject_name VARCHAR(100),
    subject_code VARCHAR(10) UNIQUE
);

CREATE TABLE EXAM (
    exam_id INT PRIMARY KEY IDENTITY,
    exam_name VARCHAR(100),
    min_mark INT,
    max_mark INT
);

CREATE TABLE MARKS (
    mark_id INT PRIMARY KEY IDENTITY,
    exam_id INT,
    student_id INT,
    subject_id INT,
    mark INT,
    FOREIGN KEY (exam_id) REFERENCES EXAM(exam_id),
    FOREIGN KEY (student_id) REFERENCES STUDENT(student_id),
    FOREIGN KEY (subject_id) REFERENCES SUBJECT(subject_id)
);
