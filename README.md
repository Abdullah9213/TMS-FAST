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

