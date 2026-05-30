# CL2005 – Database Systems Lab Manuals

**Course Code:** CL2005 – Database Systems Lab  
**Institution:** National University of Computer and Emerging Sciences (FAST-NUCES)  
**Instructor:** Amna Waheed · amna.waheed@nu.edu.pk  
**Sections:** BSAI-4A · BSAI-4B · BCS-4D · BCS-4E  
**Semester:** Spring 2024

---

## Overview

This directory contains the official lab manuals issued for CL2005 – Database Systems Lab. The course takes students from practical application development through database design to advanced SQL and PL/SQL programming using Oracle Database Express Edition.

---

## Lab Index

| # | File | Topic | Tools |
|---|------|-------|-------|
| 1 | [Lab-01-Library-Management-System-CPP.docx](Lab-01-Library-Management-System-CPP.docx) | Library Management System | C++ |
| 2 | [Lab-02-MS-Access-Expense-Tracker.docx](Lab-02-MS-Access-Expense-Tracker.docx) | MS Access Expense Tracker Application | Microsoft Access |
| 3 | [Lab-03-Windows-Forms-Registration-App-CSharp.docx](Lab-03-Windows-Forms-Registration-App-CSharp.docx) | Windows Forms Registration App | C#, Visual Studio |
| 4 | [Lab-04-Entity-Relationship-Diagrams-ERD.docx](Lab-04-Entity-Relationship-Diagrams-ERD.docx) | Entity Relationship Diagrams (ERD) | MS Visio |
| 5 | [Lab-05-Enhanced-Entity-Relationship-Diagrams-EERD.docx](Lab-05-Enhanced-Entity-Relationship-Diagrams-EERD.docx) | Enhanced Entity Relationship Diagrams (EERD) | MS Visio |
| 6 | [Lab-06-DDL-CREATE-Statements-MySQL.docx](Lab-06-DDL-CREATE-Statements-MySQL.docx) | DDL – CREATE, ALTER, and DROP Statements | MySQL |
| 7 | [Lab-07-Oracle-SQL-Fundamentals.docx](Lab-07-Oracle-SQL-Fundamentals.docx) | Oracle SQL Fundamentals | Oracle Database XE |
| 8 | [Lab-08-SQL-Joins-Oracle.docx](Lab-08-SQL-Joins-Oracle.docx) | SQL Joins | Oracle Database XE |
| 9 | [Lab-09-DDL-Statements-Oracle-BSAI.docx](Lab-09-DDL-Statements-Oracle-BSAI.docx) | DDL Statements on Oracle (BSAI Sections) | Oracle Database XE |
| 10 | [Lab-10-Database-Views-Oracle.docx](Lab-10-Database-Views-Oracle.docx) | Database Views | Oracle Database XE |
| 11 | [Lab-11-PLSQL-Variables-and-Control-Structures.docx](Lab-11-PLSQL-Variables-and-Control-Structures.docx) | PL/SQL – Variables and Control Structures | Oracle Database XE |
| 12 | [Lab-12-PLSQL-Stored-Procedures-and-Functions.docx](Lab-12-PLSQL-Stored-Procedures-and-Functions.docx) | PL/SQL – Stored Procedures and Functions | Oracle Database XE |
| 13 | [Lab-13-PLSQL-Triggers.docx](Lab-13-PLSQL-Triggers.docx) | PL/SQL – Triggers | Oracle Database XE |
| 15 | [Lab-15-PLSQL-Cursors.docx](Lab-15-PLSQL-Cursors.docx) | PL/SQL – Cursors | Oracle Database XE |

> **Note:** Lab 14 is not present in this collection.

---

## Course Progression

### Phase 1: Application Development (Labs 1–3)

Labs 1–3 introduce database-backed application development using C++, Microsoft Access, and C#.

- **Lab 1 – C++ Library Management System:** Design and build a CLI application to manage a library's book inventory. Covers file I/O, data management, and report generation in C++.
- **Lab 2 – MS Access Expense Tracker:** Create a GUI-based expense tracking database in Microsoft Access, covering table design, form creation, and monthly/yearly report generation.
- **Lab 3 – Windows Forms Registration App:** Build a user registration form using C# and Windows Forms in Visual Studio, introducing GUI design and data binding.

### Phase 2: Database Design (Labs 4–5)

Labs 4–5 focus on conceptual and logical database modeling using diagramming tools.

- **Lab 4 – Entity Relationship Diagrams (ERD):** Draw ERDs on paper then recreate them in MS Visio. Covers entities, attributes, primary keys, and relationship cardinalities across multiple case studies.
- **Lab 5 – Enhanced Entity Relationship Diagrams (EERD):** Extends ERD with EERD concepts including specialization, generalization, aggregation, and inheritance hierarchies.

### Phase 3: SQL and Oracle Database (Labs 6–10)

Labs 6–10 introduce SQL using MySQL and Oracle Database XE with the built-in EMP and DEPT tables.

- **Lab 6 – DDL CREATE Statements (MySQL):** Write `CREATE TABLE` statements with constraints — `NOT NULL`, `UNIQUE`, `PRIMARY KEY`, `FOREIGN KEY`, `CHECK`. Covers the `jobs` and `countries` schemas.
- **Lab 7 – Oracle SQL Fundamentals:** Basic `SELECT` queries and DML statements (`INSERT`, `UPDATE`, `DELETE`) using Oracle's built-in DEPT and EMP tables.
- **Lab 8 – SQL Joins:** `INNER JOIN`, `OUTER JOIN`, self-joins, and aggregate queries with `GROUP BY` on the EMP/DEPT tables.
- **Lab 9 – DDL Statements on Oracle (BSAI Sections):** `CREATE`, `ALTER`, and `DROP` operations on an Oracle database using a `Product` table schema.
- **Lab 10 – Database Views:** Create and query SQL views (e.g., `HighSalaries`). Covers view creation, querying, and `CREATE OR REPLACE`.

### Phase 4: PL/SQL Programming (Labs 11–15)

Labs 11–15 cover Oracle's procedural SQL extension, progressively building programming complexity.

- **Lab 11 – PL/SQL Variables and Control Structures:** Declare variables using `%TYPE` and `%ROWTYPE`, initialize values, use `IF-ELSE` conditionals, and implement loops with even/odd checks and incentive calculations.
- **Lab 12 – Stored Procedures and Functions:** Create parameterized stored procedures (e.g., `minmax`) and named functions using `CREATE OR REPLACE`. Output via `DBMS_OUTPUT.PUT_LINE`.
- **Lab 13 – Triggers:** Write `BEFORE` and `AFTER` triggers on DML events. Includes basic triggers, conditional salary-check triggers, and audit-log triggers.
- **Lab 15 – Cursors:** Implement explicit cursors, parameterized cursors, and `CURSOR FOR` loops to iterate over query result sets from the EMP table.

---

## Tools and Technologies

| Tool | Purpose |
|------|---------|
| Oracle Database Express Edition (XE) 21c | SQL and PL/SQL labs (Labs 7–15) |
| MySQL Community Edition | DDL exercises (Lab 6) |
| Microsoft Access | Database application development (Lab 2) |
| Microsoft Visio | ER and enhanced ER diagramming (Labs 4–5) |
| Visual Studio / C# | Windows Forms GUI development (Lab 3) |
| C++ | CLI application development (Lab 1) |

---

## Submission Format

All Oracle-based labs (Labs 6–15) require submission as a Word document containing SQL/PL/SQL queries in full alongside complete screenshots of Oracle output for each task.

Labs 4 and 5 require the MS Visio diagram exported as a PDF submitted via Google Classroom, plus the original paper drawing returned to the instructor.
