use PracticeDDL;

DROP TABLE IF EXISTS Students;
CREATE TABLE Students
(
    id int,
    name VARCHAR(50),
    age int,
    course VARCHAR(50),
);

INSERT INTO Students
    (id, name, age, course)
VALUES
    (1, 'Amit', 20, 'CSE'),
    (2, 'Neha', 21, 'IT'),
    (3, 'Rahul', 22, 'Mechanical'),
    (4, 'Priya', 20, 'Electrical'),
    (5, 'Sanjay', 23, 'Civil'),
    (6, 'Anita', 21, 'CSE'),
    (7, 'Vikas', 24, 'IT'),
    (8, 'Pooja', 22, 'Electronics'),
    (9, 'Karan', 23, 'CSE'),
    (10, 'Riya', 20, 'Mechanical')
;

-- 1. command to print the table data  ---- DQL----
SELECT * FROM Students;

-- 2. Alter: add a column(field) in the table
ALTER TABLE Students ADD email VARCHAR(100) UNIQUE;

-- 3. Modify the existing data using the Alter
ALTER TABLE Students ALTER COLUMN name VARCHAR(100);

-- ALter data if exist - make primary key 

ALTER TABLE Students ALTER COLUMN name VARCHAR(100) NOT NULL;

ALTER TABLE Students ALTER COLUMN id INT NOT NULL;

ALTER TABLE Students ADD CONSTRAINT PK_Students PRIMARY KEY(id);

SELECT * FROM Students;

-- 4. delete
DROP TABLE IF EXISTS Demo;
CREATE TABLE Demo (
    name varchar(50),
    id int UNIQUE,
);

INSERT INTO Demo(name, id) VALUES('Vijay', 101);
INSERT INTO Demo(name, id) VALUES('Kumar', 102); 
INSERT INTO Demo(name, id) VALUES('Gupta', 103);
SELECT * from Demo;

-- =====Delete=== Roll back possible
-- delete 1 record from table
DELETE FROM Demo WHERE id = 103 AND name = 'gupta';
SELECT * FROM Demo;

-- delete all data (record from the tabe) 
DELETE FROM Demo;
SELECT * FROM Demo;
-- ----------------
BEGIN TRANSACTION;

DELETE FROM Demo
WHERE id = 103;

-- print before roll back
SELECT * FROM Demo;

ROLLBACK;
-- print after roll back
SELECT * FROM Demo;


-- delete the table data random means  roll back not possible
TRUNCATE TABLE Demo;
SELECT * FROM Demo;

-- truncate rollback not possible
BEGIN TRANSACTION;
TRUNCATE TABLE Demo;
ROLLBACK;
SELECT * FROM Demo;

-- Drop use to delete the complete structure
DROP TABLE Demo;

-- DML (Data Manipulation Language)
-- update: use to update the existing record in the table
-- update the riya course computer science
UPDATE Students
SET age = 22, course = 'Computer Science' WHERE id = 10;
SELECT * FROM Students;

/* =========================================================
   DATABASE SELECTION
   ========================================================= */

-- Use the PracticeDDL database
USE PracticeDDL;



/* =========================================================
   TABLE CREATION (DDL - Data Definition Language)
   ========================================================= */

-- Drop Students table if already exists (safe recreation)
DROP TABLE IF EXISTS Students;

-- Create Students table with required columns
CREATE TABLE Students
(
    id INT,
    -- Student ID
    name VARCHAR(50),
    -- Student name
    age INT,
    -- Student age
    course VARCHAR(50)
    -- Course name
);



/* =========================================================
   INSERT DATA (DML - Data Manipulation Language)
   ========================================================= */

-- Insert multiple records into Students table
INSERT INTO Students
    (id, name, age, course)
VALUES
    (1, 'Amit', 20, 'CSE'),
    (2, 'Neha', 21, 'IT'),
    (3, 'Rahul', 22, 'Mechanical'),
    (4, 'Priya', 20, 'Electrical'),
    (5, 'Sanjay', 23, 'Civil'),
    (6, 'Anita', 21, 'CSE'),
    (7, 'Vikas', 24, 'IT'),
    (8, 'Pooja', 22, 'Electronics'),
    (9, 'Karan', 23, 'CSE'),
    (10, 'Riya', 20, 'Mechanical');



/* =========================================================
   SELECT DATA (DQL - Data Query Language)
   ========================================================= */

-- Display all students
SELECT *
FROM Students;



/* =========================================================
   ALTER TABLE OPERATIONS (DDL)
   ========================================================= */

-- Add new column 'email' with UNIQUE constraint
ALTER TABLE Students
ADD email VARCHAR(100) UNIQUE;

-- Increase name column size from 50 → 100 characters
ALTER TABLE Students
ALTER COLUMN name VARCHAR(100);

-- Make name column NOT NULL
ALTER TABLE Students
ALTER COLUMN name VARCHAR(100) NOT NULL;

-- Make id column NOT NULL
ALTER TABLE Students
ALTER COLUMN id INT NOT NULL;

-- Add Primary Key constraint on id column
ALTER TABLE Students
ADD CONSTRAINT PK_Students PRIMARY KEY(id);

-- Verify structure
SELECT *
FROM Students;



/* =========================================================
   SECOND TABLE FOR DELETE/TRUNCATE/ROLLBACK DEMO
   ========================================================= */

-- Drop Demo table if exists
DROP TABLE IF EXISTS Demo;

-- Create Demo table
CREATE TABLE Demo
(
    name VARCHAR(50),
    id INT UNIQUE
);

-- Insert sample records
INSERT INTO Demo
VALUES
    ('Vijay', 101);
INSERT INTO Demo
VALUES
    ('Kumar', 102);
INSERT INTO Demo
VALUES
    ('Gupta', 103);

-- Show Demo table
SELECT *
FROM Demo;



/* =========================================================
   DELETE COMMANDS (DML)
   ========================================================= */

-- Delete single specific record (case-sensitive depending on DB)
DELETE FROM Demo
WHERE id = 103 AND name = 'Gupta';

SELECT *
FROM Demo;


-- Delete all rows (structure remains, rollback possible)
DELETE FROM Demo;

SELECT *
FROM Demo;



/* =========================================================
   TRANSACTION CONTROL (TCL)
   ========================================================= */

-- Start transaction
BEGIN TRANSACTION;

-- Delete specific record
DELETE FROM Demo WHERE id = 103;

-- Check before rollback
SELECT *
FROM Demo;

-- Undo changes
ROLLBACK;

-- Check after rollback
SELECT *
FROM Demo;



/* =========================================================
   TRUNCATE TABLE (DDL - Faster, rollback not possible usually)
   ========================================================= */

-- Remove all records quickly (cannot normally rollback)
TRUNCATE TABLE Demo;

SELECT *
FROM Demo;


-- Demonstrating truncate inside transaction (may not rollback in most DBs)
BEGIN TRANSACTION;
TRUNCATE TABLE Demo;
ROLLBACK;

SELECT *
FROM Demo;



/* =========================================================
   DROP TABLE (DDL)
   ========================================================= */

-- Delete complete table structure permanently
DROP TABLE Demo;



/* =========================================================
   UPDATE COMMAND (DML)
   ========================================================= */

-- Update Riya's age and course
UPDATE Students
SET age = 22,
    course = 'Computer Science'
WHERE id = 10;

-- Verify update
SELECT *
FROM Students;


