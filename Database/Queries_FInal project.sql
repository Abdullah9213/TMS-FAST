--Admin functionality
use master
Use T_M_S


drop function  GetStudentPersonalInfo;
drop function GetStudentThesisInfo;
-- Student home page- personal info function
GO
CREATE FUNCTION GetStudentPersonalInfo (@UserName VARCHAR(50))
RETURNS TABLE
AS
RETURN
(
    SELECT *  FROM Users s
    WHERE s.username = @UserName
);
GO

-- Student home page- thesis info function
GO
SELECT * FROM GetStudentPersonalInfo('ali.khan');

CREATE FUNCTION GetStudent_ThesisInfo (@student_username VARCHAR(50))
RETURNS TABLE
AS
RETURN (
  SELECT
    u_student.username AS student_username,  -- Username instead of user ID
    s.registration_number,
    p.program_name,
    t.thesis_id,
    t.title,
    t.description,
    u_supervisor.username AS supervisor_username,  -- Username instead of user ID
    u_supervisor.first_name AS supervisor_first_name,
    u_supervisor.last_name AS supervisor_last_name,
    u_examiner1.username AS examiner1_username,  -- Username instead of user ID
    u_examiner1.first_name AS examiner1_first_name,
    u_examiner1.last_name AS examiner1_last_name,
    u_examiner2.username AS examiner2_username,  -- Username instead of user ID
    u_examiner2.first_name AS examiner2_first_name,
    u_examiner2.last_name AS examiner2_last_name
  FROM Students s
  INNER JOIN Theses t ON s.student_id = t.student_id
  INNER JOIN Programs p ON s.program_id = p.program_id
  LEFT JOIN ThesisAssignments ta ON t.thesis_id = ta.thesis_id
  LEFT JOIN Faculty f_supervisor ON ta.supervisor_id = f_supervisor.faculty_id  -- Supervisor
  INNER JOIN Users u_supervisor ON f_supervisor.user_id = u_supervisor.user_id  -- Join Users with Supervisor alias
  LEFT JOIN Faculty f1 ON ta.examiner_id1 = f1.faculty_id  -- Examiner 1
  INNER JOIN Users u_examiner1 ON f1.user_id = u_examiner1.user_id  -- Join Users with Examiner 1 alias
  LEFT JOIN Faculty f2 ON ta.examiner_id2 = f2.faculty_id  -- Examiner 2
  INNER JOIN Users u_examiner2 ON f2.user_id = u_examiner2.user_id  -- Join Users with Examiner 2 alias
  INNER JOIN Users u_student ON s.user_id = u_student.user_id  -- Join Users with Students table
  WHERE u_student.username = @student_username  -- Filter by username
);

SELECT * FROM GetStudent_ThesisInfo('ali.khan');





---------------------------------------------------------------------------------------------------------------













--2 table joins
SELECT Users.username, Roles.role_name
FROM Users
INNER JOIN Roles ON Users.role_id = Roles.role_id;

SELECT Students.registration_number, Programs.program_name
FROM Students
INNER JOIN Programs ON Students.program_id = Programs.program_id;

SELECT Theses.title, Students.registration_number
FROM Theses
INNER JOIN Students ON Theses.student_id = Students.student_id;

SELECT Documents.document_name, Theses.title
FROM Documents
INNER JOIN Theses ON Documents.thesis_id = Theses.thesis_id;






--3 table joins
SELECT Users.username, Roles.role_name, Students.registration_number
FROM Users
INNER JOIN Roles ON Users.role_id = Roles.role_id
INNER JOIN Students ON Users.user_id = Students.user_id;

SELECT Users.username, Theses.title, Documents.document_name
FROM Users
INNER JOIN Theses ON Users.user_id = Theses.student_id
INNER JOIN Documents ON Theses.thesis_id = Documents.thesis_id;

SELECT Students.registration_number, Theses.title, Documents.document_name
FROM Students
INNER JOIN Theses ON Students.student_id = Theses.student_id
INNER JOIN Documents ON Theses.thesis_id = Documents.thesis_id;

SELECT Users.username, Roles.role_name, Faculty.program_id
FROM Users
INNER JOIN Roles ON Users.role_id = Roles.role_id
INNER JOIN Faculty ON Users.user_id = Faculty.user_id;




--4 table join
SELECT Users.username, Roles.role_name, Students.registration_number, Programs.program_name
FROM Users
INNER JOIN Roles ON Users.role_id = Roles.role_id
INNER JOIN Students ON Users.user_id = Students.user_id
INNER JOIN Programs ON Students.program_id = Programs.program_id;

SELECT Users.username, Theses.title, Documents.document_name, Feedback.content
FROM Users
INNER JOIN Theses ON Users.user_id = Theses.student_id
INNER JOIN Documents ON Theses.thesis_id = Documents.thesis_id
INNER JOIN Feedback ON Users.user_id = Feedback.user_id;

SELECT Students.registration_number, Theses.title, Documents.document_name, Feedback.content
FROM Students
INNER JOIN Theses ON Students.student_id = Theses.student_id
INNER JOIN Documents ON Theses.thesis_id = Documents.thesis_id
INNER JOIN Feedback ON Students.user_id = Feedback.user_id;



--views
CREATE VIEW UserRoles AS
SELECT Users.username, Roles.role_name
FROM Users
INNER JOIN Roles ON Users.role_id = Roles.role_id;



CREATE VIEW StudentPrograms AS
SELECT Students.registration_number, Programs.program_name
FROM Students
INNER JOIN Programs ON Students.program_id = Programs.program_id;

CREATE VIEW ThesisStudents AS
SELECT Theses.title, Students.registration_number
FROM Theses
INNER JOIN Students ON Theses.student_id = Students.student_id;


CREATE VIEW UserStudentRoles AS
SELECT Users.username, Roles.role_name, Students.registration_number
FROM Users
INNER JOIN Roles ON Users.role_id = Roles.role_id
INNER JOIN Students ON Users.user_id = Students.user_id;

CREATE VIEW UserThesisDocuments AS
SELECT Users.username, Theses.title, Documents.document_name
FROM Users
INNER JOIN Theses ON Users.user_id = Theses.student_id
INNER JOIN Documents ON Theses.thesis_id = Documents.thesis_id;



--trigger



CREATE TRIGGER trg_AuditUsers
ON Users
AFTER INSERT, DELETE
AS
BEGIN
  IF EXISTS (SELECT * FROM inserted)
  BEGIN
    INSERT INTO AuditLog (Action, TableName, RecordId, ActionDate)
    SELECT 'Insert', 'Users', user_id, GETDATE() FROM inserted
  END

  IF EXISTS (SELECT * FROM deleted)
  BEGIN
    INSERT INTO AuditLog (Action, TableName, RecordId, ActionDate)
    SELECT 'Delete', 'Users', user_id, GETDATE() FROM deleted
  END
END;


--having clause
SELECT COUNT(*) AS UserCount, role_id
FROM Users
GROUP BY role_id
HAVING COUNT(*) > 1;

SELECT COUNT(*) AS StudentCount, program_id
FROM Students
GROUP BY program_id
HAVING COUNT(*) > 1;

SELECT COUNT(*) AS DocumentCount, thesis_id
FROM Documents
GROUP BY thesis_id
HAVING COUNT(*) > 1;

SELECT AVG(proposal_marks) AS AvgProposalMarks, examiner_type
FROM Marks
GROUP BY examiner_type
HAVING AVG(proposal_marks) > 50;

SELECT SUM(proposal_marks) AS TotalProposalMarks, examiner_type
FROM Marks
GROUP BY examiner_type
HAVING SUM(proposal_marks) > 100;




