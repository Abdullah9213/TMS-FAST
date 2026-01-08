--DATABASE CREATION
use master
USE T_M_S

-- 1. Roles table (Stores different user roles)
CREATE TABLE Roles (
  role_id INT PRIMARY KEY IDENTITY(1,1),
  role_name VARCHAR(50) UNIQUE NOT NULL
);

-- 2. Users table (Centralized user information)
CREATE TABLE Users (
  user_id INT PRIMARY KEY IDENTITY(1,1),
  username VARCHAR(50) UNIQUE NOT NULL,
  password VARCHAR(255) NOT NULL,  
  first_name VARCHAR(50) NOT NULL,	
  last_name VARCHAR(50) NOT NULL,
  email VARCHAR(100) UNIQUE NOT NULL,
  role_id INT NOT NULL,
  FOREIGN KEY (role_id) REFERENCES Roles(role_id)
);

-- 3. Programs table (Stores program names)
CREATE TABLE Programs (
  program_id INT PRIMARY KEY IDENTITY(1,1),
  program_name VARCHAR(100) NOT NULL
);

-- 4. Students table (References Users and Programs)
CREATE TABLE Students (
  student_id INT PRIMARY KEY IDENTITY(1,1),
  user_id INT NOT NULL UNIQUE,  -- Ensures one user per student
  registration_number VARCHAR(20) UNIQUE NOT NULL,
  program_id INT NOT NULL,
  FOREIGN KEY (user_id) REFERENCES Users(user_id),
  FOREIGN KEY (program_id) REFERENCES Programs(program_id)
);

-- 5. Supervisors/Examiners/Committee Members table (Unified Faculty table)
CREATE TABLE Faculty (
  faculty_id INT PRIMARY KEY IDENTITY(1,1),
  user_id INT NOT NULL UNIQUE,  -- Ensures one user per faculty member
  program_id INT,  -- Optional: Faculty member's program of expertise
  FOREIGN KEY (user_id) REFERENCES Users(user_id),
  FOREIGN KEY (program_id) REFERENCES Programs(program_id)
);

-- 6. Theses table (Improved structure)
CREATE TABLE Theses (
  thesis_id INT PRIMARY KEY IDENTITY(1,1),
  student_id INT NOT NULL,
  title VARCHAR(255) NOT NULL,
  description TEXT,
  submission_date DATETIME,
  FOREIGN KEY (student_id) REFERENCES Students(student_id)
);

-- 7. ThesisAssignments table (Manages thesis assignments)
CREATE TABLE ThesisAssignments (
  assignment_id INT PRIMARY KEY IDENTITY(1,1),
  thesis_id INT NOT NULL,
  supervisor_id INT NOT NULL,
  examiner_id1 INT NOT NULL,  -- First examiner
  examiner_id2 INT NOT NULL,  -- Second examiner
  committee_member_id INT,  -- Optional: Committee member can be assigned later
  FOREIGN KEY (thesis_id) REFERENCES Theses(thesis_id),
  FOREIGN KEY (supervisor_id) REFERENCES Faculty(faculty_id),
  FOREIGN KEY (examiner_id1) REFERENCES Faculty(faculty_id),
  FOREIGN KEY (examiner_id2) REFERENCES Faculty(faculty_id),
  FOREIGN KEY (committee_member_id) REFERENCES Faculty(faculty_id)
);


-- 8. Documents table (Stores thesis documents)
CREATE TABLE Documents (
  document_id INT PRIMARY KEY IDENTITY(1,1),
  thesis_id INT NOT NULL,
  document_name VARCHAR(255) NOT NULL,
  document_type VARCHAR(50) NOT NULL,
  file_path VARCHAR(255),  -- Consider storing files elsewhere
  version_number INT,
  FOREIGN KEY (thesis_id) REFERENCES Theses(thesis_id)
);

-- 9. Feedback table (Improved with cascade delete)
CREATE TABLE Feedback (
  feedback_id INT PRIMARY KEY IDENTITY(1,1),
  document_id INT NOT NULL,
  user_id INT NOT NULL,
  content TEXT,
  timestamp DATETIME,
  FOREIGN KEY (document_id) REFERENCES Documents(document_id),
  FOREIGN KEY (user_id) REFERENCES Users(user_id) ON DELETE CASCADE  -- Delete feedback if user is deleted
);

-- 10. SignupRequests table (Tracks signup requests)
CREATE TABLE SignupRequests (
  request_id INT PRIMARY KEY IDENTITY(1,1),
  username VARCHAR(50) NOT NULL,
  password VARCHAR(255) NOT NULL,
  first_name VARCHAR(50) NOT NULL,
  last_name VARCHAR(50) NOT NULL,
  email VARCHAR(100) UNIQUE NOT NULL,
  role_id INT NOT NULL,
  FOREIGN KEY (role_id) REFERENCES Roles(role_id)
);

-- 11. Marks table 
  mark_id INT PRIMARY KEY IDENTITY,
  student_id INT FOREIGN KEY REFERENCES Students(student_id),
  examiner_type VARCHAR(20) CHECK (examiner_type IN ('Supervisor', 'Examiner1', 'Examiner2')),
  proposal_marks INT NULL,
  mid_marks INT NULL,
  presentation_marks INT NULL,
  report_marks INT NULL,
);


-- 12. Create Submissions table
CREATE TABLE Submissions (
  submission_id INT PRIMARY KEY IDENTITY(1,1),
  thesis_id INT NOT NULL,
  submission_type VARCHAR(50) NOT NULL,  
  filename VARCHAR(255) NOT NULL,
  file_path VARCHAR(255) NOT NULL,
  submission_date DATETIME NOT NULL DEFAULT (GETUTCDATE()), 
  FOREIGN KEY (thesis_id) REFERENCES Theses(thesis_id)  
);

-- 13 Auditlog
CREATE TABLE AuditLog (
    LogId INT PRIMARY KEY IDENTITY(1,1),
    Action VARCHAR(50),
    TableName VARCHAR(50),
    RecordId INT,
    ActionDate DATETIME
);

