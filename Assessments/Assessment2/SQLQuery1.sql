CREATE TABLE Patient (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Age INT,
    Gender NVARCHAR(10),
    MedicalCondition NVARCHAR(200)
);

CREATE TABLE Doctor (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Specialization NVARCHAR(100),
    PatientId INT NULL,
    FOREIGN KEY (PatientId) REFERENCES Patient(Id)
);
