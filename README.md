Thesis Management System (TMS) - FAST NUCES
Course: Software Engineering (SE-B)

Instructor: Mr. Asif Muhammad

Authors: Abdullah (22i-2515) & Shoaib Mehmood (22i-2448)

Department: Computer Science, FAST - National University of Computer & Emerging Sciences

📖 Project Overview
The Thesis Management System (TMS) is a web-based solution designed to digitize and streamline the manual thesis workflow for MS students, faculty, and administrators at FAST-NUCES.

Previously, the thesis process involved fragmented communication, manual form submissions (Thesis Registration, Supervisor Change, etc.), and difficult progress tracking. This system centralizes these activities, allowing students to register for thesis credits, submit proposals, receive feedback, and view grades, while enabling faculty to manage panels, evaluate submissions, and track student progress efficiently.

🚀 Key Features
🎓 For Students
Personal Dashboard: View registration details, program info, and current thesis status.

Thesis Management: Register for Thesis I/II and submit research proposals.

Document Submission: Upload thesis deliverables (Proposal, Mid-defense, Final Report) with version tracking.

Feedback Loop: Receive timestamped feedback directly from Supervisors and Examiners.

Digital Forms: Submit requests for "Title Change," "Supervisor Change," or "Examiner Change" online.

👨‍🏫 For Faculty (Supervisors & Examiners)
Role-Based Access: Distinct views for Supervisors, Internal/External Examiners, and Committee Members.

Request Management: Accept or decline student thesis requests and form applications.

Grading System: Input and manage marks for Proposals, Mid-Evals, Presentations, and Final Reports.

Panel Management: View assigned students and thesis defense schedules.

🛠 For Admin/Academic Officers
User Management: detailed CRUD operations for Students and Faculty.

Panel Creation: Create defense panels and assign examiners to specific theses.

Audit Logging: Automated tracking of sensitive user actions (Insert/Delete operations on Users) for security.

🗄️ Database Architecture
The system is built on a robust Microsoft SQL Server database. The repository includes the complete database design and implementation scripts:

ERD/EERD: Normalized relational schema handling complex relationships between Students, Faculty roles, and Theses.

Stored Procedures & Functions: Custom scripts (e.g., GetStudent_ThesisInfo) to retrieve dynamic user dashboards.

Triggers: Security triggers (e.g., trg_AuditUsers) to automatically log changes to the Users table.

Views: Pre-built views for generating reports on Student Roles and Thesis Documents.

📂 Repository Structure
Plaintext

├── Documentation
│   ├── i222515_i222448_SE(B)_Final Report.pdf  # Comprehensive project report & user guide
│   ├── TMS_ERD.pdf                             # Entity Relationship Diagram
│   ├── TMS_EERD.pdf                            # Enhanced Entity Relationship Diagram
│   └── TMS Relational Schema.pdf               # Database Schema Blueprint
│
├── Database Scripts
│   ├── Refresh T_M_S.sql                       # Script to drop/reset the database
│   ├── T_M_S_Creation.sql                      # Main DDL script (Creates Tables & Constraints)
│   ├── T_M_S Insertion.sql                     # DML script (Populates DB with dummy data)
│   └── Queries_FInal project.sql               # Stored Procedures, Views, Triggers, and Complex Joins
⚙️ Installation & Database Setup
To set up the database environment locally using SQL Server Management Studio (SSMS):

Open SSMS and connect to your local server instance.

Reset/Initialize: Open and execute Refresh T_M_S.sql.

Note: This will Drop the database T_M_S if it exists and create a fresh one.

Create Schema: Open and execute T_M_S_Creation.sql.

This builds all tables (Users, Roles, Theses, Submissions, Marks, etc.) and defines Foreign Keys.

Seed Data: Open and execute T_M_S Insertion.sql.

This inserts sample data (Students, Supervisors, Admin accounts) for testing.

Setup Logic: Open and execute Queries_FInal project.sql.

This installs the necessary Stored Procedures, Functions, and Triggers required for the application logic.

🧪 Usage Examples (SQL)
Once the database is set up, you can run the following test queries:

1. Retrieve a Student's Thesis Dashboard:

SQL

SELECT * FROM GetStudent_ThesisInfo('ali.khan');
2. Check the Audit Log for User Changes:

SQL

SELECT * FROM AuditLog;
3. View Thesis Documents:

SQL

SELECT * FROM UserThesisDocuments;
👥 Contributors
Abdullah (22i-2515)

Shoaib Mehmood (22i-2448)
# TMS-FAST

TMS-FAST is a Windows Forms application for managing student/teacher workflows, submissions, and academic schedules. It was developed as a course project and includes a Visual Studio solution under the `login_page` folder plus SQL scripts in the `Database` folder to create and populate the database.

**Features**
- **User login / signup**: basic authentication UI.
- **Student submission**: students can submit assignments/results.
- **Teacher workflows**: multiple teacher forms for submitting and managing marks.
- **Supervisor features**: supervisor marks submission and examination changes.

**Prerequisites**
- Windows
- Visual Studio 2017 or newer (with Windows Forms / .NET desktop workload)
- .NET Framework 4.7.2
- SQL Server (or compatible) to run the provided SQL scripts

**Getting Started (open & run)**
- Open the solution: [login_page/login_page.sln](login_page/login_page.sln)
- In Visual Studio, set the startup project to `login_page` and build (Build → Build Solution).
- Run the app (F5) or run the generated executable from `login_page/bin/Debug`.

**Database setup**
- See the SQL scripts in the `Database` folder: [Database/](Database)
	- `T_M_S_Creation.sql` — create schema/tables
	- `T_M_S Insertion.sql` — sample data insertion
	- `Queries_FInal project.sql` — example queries used in the project
- Import or run these scripts on your SQL Server instance and update the connection string in `login_page/App.config` if necessary.

**Configuration**
- Database connection string and other settings are stored in: [login_page/login_page/App.config](login_page/login_page/App.config)
- If you change the target database or credentials, update that file before running the application.

**Build and Packaging**
- For a release build, switch to the `Release` configuration, build the solution, and distribute the EXE from `login_page/bin/Release`.

**Notes & Troubleshooting**
- Target framework is `.NET Framework 4.7.2` (see `login_page/login_page.csproj`). Ensure your Visual Studio installation supports it.
- If Visual Studio complains about missing NuGet packages or references, restore packages and rebuild the solution.

**Contributing**
- This repository contains a classroom project. If you want to contribute, open an issue or submit a pull request with a clear description of changes.

**Contact**
- Project owner: Abdullah9213 — i222515@nu.edu.pk

**License**
- MIT

**Detailed Report & Images**
- A full project write-up with diagrams and screenshots is included as: [Final Report.pdf](Final%20Report.pdf). It contains the project overview, system design diagrams (ERD/EERD), screenshots of the application, and implementation details.
- If you want the screenshots embedded directly in this `README.md`, I can extract images from `Final Report.pdf`, add them to `docs/images/`, and reference them here. This requires extracting images locally (using `pdfimages` or a PDF editor). If you want me to proceed, tell me and I will either:
	1. Run extraction commands here if allowed, or
	2. Provide exact commands for you to run locally and then I'll add the exported images into `docs/images/` and embed them in the README.

Files with additional documentation and diagrams:
- [Final Report.pdf](Final%20Report.pdf)
- [TMS_ERD.pdf](TMS_ERD.pdf)
- [TMS_EERD.pdf](TMS_EERD.pdf)
- [TMS Relational Schema.pdf](TMS%20Relational%20Schema.pdf)

