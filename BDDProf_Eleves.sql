CREATE DATABASE SchoolInfos;

USE SchoolInfos;

CREATE TABLE School (
id INT PRIMARY KEY IDENTITY(1,1),
[name] VARCHAR(80) NOT NULL,
adress VARCHAR(255),
teachersNumber INT NOT NULL,
studentsNumber INT NOT NULL
);

CREATE TABLE Teacher (
id INT PRIMARY KEY IDENTITY (1,1),
[lastName] VARCHAR(80) NOT NULL,
[firstName] VARCHAR(80) NOT NULL,
discipline VARCHAR(80) NOT NULL,
school_id INT,
CONSTRAINT Fk_schoolID FOREIGN KEY (school_id) REFERENCES School(id),
generalMean DECIMAL(4,2)
);

CREATE TABLE Students (
id INT PRIMARY KEY INDENTITY(1,1),
[lastName] VARCHAR(80) NOT NULL,
[firstName] VARCHAR(80) NOT NULL,
class VARCHAR(80) NOT NULL,
teacher_id INT,
CONSTRAINT Fk_teacherID FOREIGN KEY (teacher_id) REFERENCES Teacher(id),
generalMean DECIMAL(4,2)
);

