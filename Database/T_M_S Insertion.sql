--DATABASE INSERTION
use master
USE T_M_S

INSERT INTO Roles (role_name)
VALUES ('Student'),
('Supervisor'),
('Examiner'),
('Committee Member'),
('Admin');

INSERT INTO Users (username, password, first_name, last_name, email, role_id)
VALUES ('ali.khan', 'hashed_password', 'Ali', 'Khan', 'ali.khan@FAST.edu.pk', 1),  -- Student
       ('amina.raza', 'hashed_password', 'Amina', 'Raza', 'amina.raza@qau.edu.pk', 2),  -- Supervisor
       ('bilal.ahmed', 'hashed_password', 'Bilal', 'Ahmed', 'bilal.ahmed@uet.edu.pk', 3),  -- Examiner
       ('samia.khan', 'hashed_password', 'Samia', 'Khan', 'samia.khan@lums.edu.pk', 4),   -- Committee Member
       ('admin', 'hashed_password', 'Admin', 'User', 'admin@tms.edu.pk', 5);  -- Admin

INSERT INTO Users (username, password, first_name, last_name, email, role_id)
VALUES ('bilal.ahmed1', 'hashed_password', 'Bilal', 'Ahmed', 'bilal.ahmed1@uet.edu.pk', 2),
('ali.khan1', 'hashed_password', 'Ali', 'Khan', 'ali.khan1@FAST.edu.pk', 3),  -- Examiner
('samia.khan1', 'hashed_password', 'Samia', 'Khan', 'samia.khan1@lums.edu.pk', 3);


INSERT INTO Programs (program_name)
VALUES ('MS Computer Science'),
       ('MS Electrical Engineering'),
       ('MBA');


INSERT INTO Students (user_id, registration_number, program_id)
VALUES (1, 'FAST-CS-2023-1', 1),  -- Ali Khan (MS CS)
       (2, 'QAU-EE-2022-2', 2);   -- Amina Raza (MS EE)

INSERT INTO Faculty (user_id, program_id)
VALUES 
	
		(3, 1),  -- Bilal Ahmed (Expertise: CS)
       (4, 2),  -- Samia Khan (Expertise: EE)
       (5, NULL); -- Admin (no program expertise)


INSERT INTO Theses (student_id, title, description)
VALUES (1, 'Machine Learning for Image Recognition', 'This thesis explores the use of machine learning techniques for image recognition tasks...'),
       (2, 'Power System Optimization using Genetic Algorithms', 'This thesis investigates the application of genetic algorithms for optimizing power system operations...');
	   UPDATE Users
SET role_id = 3  -- Set role to 'Examiner' (assuming role ID 3 is 'Examiner')
WHERE user_id = 5;


 INSERT INTO ThesisAssignments (thesis_id, supervisor_id, examiner_id1, examiner_id2)
VALUES (1, 1, 2, 3),  -- Ali Khan - Bilal Ahmed (Supervisor), Amina Raza (Examiner 1), Admin (Examiner 2)
       (2, 1, 2, 3);   -- Amina Raza - Samia Khan (Supervisor), Bilal Ahmed (Examiner 1), Admin (Examiner 2)


	   select * from Users