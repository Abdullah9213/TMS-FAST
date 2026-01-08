# Thesis Management System (TMS) — FAST-NUCES

**Course:** Software Engineering (SE-B)  
**Instructor:** Mr. Asif Muhammad  
**Authors:** Abdullah (22i-2515) & Shoaib Mehmood (22i-2448)  
**Department:** Computer Science, FAST — National University of Computer & Emerging Sciences

---

## Overview

The Thesis Management System (TMS) is a web-based application that digitizes and streamlines the end-to-end thesis workflow for MS students, faculty, and academic officers at FAST-NUCES. It replaces manual forms and fragmented communication with a centralized platform for registration, submissions, feedback, grading, and panel management.

## Key Features

- Students
	- Personal dashboard for registration details and thesis status
	- Thesis registration (Thesis I/II) and proposal submission
	- Upload and versioned submission of proposal, mid-eval, and final report
	- Receive timestamped feedback from supervisors/examiners
	- Submit digital requests (Title Change, Supervisor Change, Examiner Change)

- Faculty (Supervisors & Examiners)
	- Role-based views and access controls
	- Manage and respond to student requests and form applications
	- Enter and manage marks for proposals, mid-evals, presentations, and final reports
	- View assigned students and defense schedules

- Admin / Academic Officers
	- Full CRUD for student and faculty user accounts
	- Create and manage defense panels and examiner assignments
	- Audit logging for sensitive operations (e.g., user insert/delete)

## Architecture & Database

The application uses Microsoft SQL Server as its backend. The repository contains the database schema, seed data, and SQL objects required by the application:

- Normalized relational schema (ERD/EERD)
- Stored procedures and functions (e.g., `GetStudent_ThesisInfo`)
- Triggers for security/auditing (e.g., `trg_AuditUsers`)
- Views for reporting (Student Roles, Thesis Documents)

## Repository Structure (high level)

Documentation

	- `i222515_i222448_SE(B)_Final Report.pdf` — Project report & user guide
	- `TMS_ERD.pdf` — Entity Relationship Diagram
	- `TMS_EERD.pdf` — Enhanced ER Diagram
	- `TMS Relational Schema.pdf` — Database schema blueprint

Database Scripts

	- `Refresh T_M_S.sql` — Drop/reset database
	- `T_M_S_Creation.sql` — DDL: tables, constraints, keys
	- `T_M_S Insertion.sql` — Seed/sample data
	- `Queries_FInal project.sql` — Stored procedures, views, triggers

Application

	- Frontend and backend project files (see project folders)

## Installation & Database Setup

1. Open SQL Server Management Studio (SSMS) and connect to your instance.
2. Execute `Refresh T_M_S.sql` to drop and recreate the `T_M_S` database.
3. Execute `T_M_S_Creation.sql` to create tables, constraints, and keys.
4. Execute `T_M_S Insertion.sql` to insert sample test data.
5. Execute `Queries_FInal project.sql` to install stored procedures, functions, views, and triggers.

Note: Running `Refresh T_M_S.sql` will remove any existing `T_M_S` database and data.

## Usage Examples (SQL)

Retrieve a student's thesis dashboard:

```sql
SELECT * FROM GetStudent_ThesisInfo('ali.khan');
```

Check the audit log for user changes:

```sql
SELECT * FROM AuditLog;
```

View thesis documents:

```sql
SELECT * FROM UserThesisDocuments;
```

## Contributors

- Abdullah (22i-2515)
- Shoaib Mehmood (22i-2448)

---
