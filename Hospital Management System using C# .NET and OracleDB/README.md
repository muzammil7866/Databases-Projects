# Hospital Management System

**Course:** CL2005 – Database Systems (Semester Project — Phase 2)  
**Student:** Muzammil Bin Sohail · Roll No: 22F-3110  
**Degree:** BS Artificial Intelligence · Section: 4A1  
**Institution:** National University of Computer and Emerging Sciences (FAST-NUCES)  
**Semester:** Spring 2024

---

## Project Overview

A **Windows Forms desktop application** built in C# (.NET Framework 4.8) that manages the core operations of a hospital — patient registration, appointment booking, medical records, prescriptions, employee management, feedback handling, and report generation. The application connects to an **Oracle Database XE** backend and implements role-based access control across five distinct user types.

---

## Features by Role

### Patient
| Feature | Description |
|---------|-------------|
| Sign Up | Register with name, email, phone, and ID proof |
| Book Appointment | Schedule a consultation with an available doctor |
| View Past Appointments | Review appointment history and statuses |
| Submit Feedback | Leave feedback on hospital experience |
| Profile Management | View and update personal details |

### Admin
| Feature | Description |
|---------|-------------|
| Manage Employees | Add, update, and remove staff records |
| Manage Appointments | Add, update, and cancel any appointment |
| Generate Reports | Produce daily, weekly, and monthly activity reports |

### Doctor / Nurse  *(EmployeeFuncFormDN)*
| Feature | Description |
|---------|-------------|
| Check Profile | View personal staff profile |
| View Patient Records | Access medical history of assigned patients |
| Manage Appointments | View and update appointment statuses |
| Generate Prescriptions | Create and issue prescriptions per appointment |

### Receptionist / Cashier  *(EmployeeFuncFormRC)*
| Feature | Description |
|---------|-------------|
| Check Profile | View personal staff profile |
| View Salary | Access salary details |
| Manage Tasks | Track and update assigned tasks |
| Customer Support | Handle front-desk customer queries |

### Customer Support Staff
| Feature | Description |
|---------|-------------|
| Check Profile | View personal staff profile |
| View Feedback | Read all submitted patient feedback |
| Resolve Issues | Mark feedback as resolved |
| Generate Reports | Produce feedback and issue-resolution reports |

---

## Project Structure

```
Database Semester Project/
│
├── DATABASE SYSTEMS PROJECT (PHASE # 2)/   ← Visual Studio solution
│   │
│   ├── Properties/
│   │   ├── AssemblyInfo.cs
│   │   ├── Resources.Designer.cs
│   │   ├── Resources.resx
│   │   └── Settings.Designer.cs / Settings.settings
│   │
│   ├── AdminFuncForm.cs / .Designer.cs / .resx
│   ├── AdminGenerateReportsForm.cs / .Designer.cs / .resx
│   ├── AdminManageAppointmentsForm.cs / .Designer.cs / .resx
│   ├── AdminManageEmployeeForm.cs / .Designer.cs / .resx
│   ├── CustomerSupportStaffForm.cs / .Designer.cs / .resx
│   ├── EmployeeFuncFormDN.cs / .Designer.cs / .resx    ← Doctor/Nurse
│   ├── EmployeeFuncFormRC.cs / .Designer.cs / .resx    ← Receptionist/Cashier
│   ├── LoginForm.cs / .Designer.cs / .resx
│   ├── PatientFuncForm.cs / .Designer.cs / .resx
│   ├── SignupForm.cs / .Designer.cs / .resx
│   ├── Program.cs                                      ← Entry point → LoginForm
│   ├── App.config
│   ├── DATABASE SYSTEMS PROJECT (PHASE # 2).csproj
│   └── DATABASE SYSTEMS PROJECT (PHASE # 2).sln
│
├── database/
│   ├── schema.sql    ← Oracle DDL: tables, sequences, triggers, views
│   └── seed.sql      ← Sample data for all tables
│
├── .gitignore
└── README.md
```

---

## Database Schema

The backend uses **Oracle Database Express Edition (XE)**. The schema is defined in [`database/schema.sql`](database/schema.sql).

### Entity Relationship Summary

```
PATIENTS ──────┬──── APPOINTMENTS ────── EMPLOYEES (Doctor)
               │         │
               │         └──── PRESCRIPTIONS
               │         │
               │         └──── MEDICAL_RECORDS
               │
               └──── FEEDBACK ─────────── EMPLOYEES (CustomerSupport)

EMPLOYEES ─────────── TASKS
EMPLOYEES ─────────── REPORTS
```

### Tables

| Table | Description | Key Columns |
|-------|-------------|-------------|
| `PATIENTS` | Registered patient accounts | `patient_id`, `name`, `email`, `phone`, `id_proof` |
| `EMPLOYEES` | All hospital staff | `employee_id`, `name`, `role`, `department`, `salary` |
| `APPOINTMENTS` | Patient–doctor bookings | `appointment_id`, `patient_id`, `doctor_id`, `status` |
| `MEDICAL_RECORDS` | Post-consultation diagnoses | `record_id`, `patient_id`, `doctor_id`, `diagnosis` |
| `PRESCRIPTIONS` | Medications issued per appointment | `prescription_id`, `appointment_id`, `medication` |
| `FEEDBACK` | Patient-submitted feedback | `feedback_id`, `patient_id`, `status` |
| `TASKS` | Staff task assignments | `task_id`, `employee_id`, `status`, `due_date` |
| `REPORTS` | Generated activity reports | `report_id`, `generated_by`, `report_type`, `report_date` |

### Employee Roles

| Role | Form | Access Level |
|------|------|-------------|
| `Admin` | `AdminFuncForm` | Full system access |
| `Doctor` | `EmployeeFuncFormDN` | Patient records, appointments, prescriptions |
| `Nurse` | `EmployeeFuncFormDN` | Patient records, appointments |
| `Receptionist` | `EmployeeFuncFormRC` | Tasks, customer support |
| `Cashier` | `EmployeeFuncFormRC` | Billing tasks, salary view |
| `CustomerSupport` | `CustomerSupportStaffForm` | Feedback, issue resolution |

### Constraints & Integrity

- **Primary keys** auto-populated via Oracle sequences + BEFORE INSERT triggers
- **Foreign keys** enforce referential integrity across all relational tables
- **CHECK constraints** validate role values, appointment status, task status, and salary
- **UNIQUE constraints** on `email` in both PATIENTS and EMPLOYEES
- **Views** provided for common join queries (`V_APPOINTMENT_DETAILS`, `V_PENDING_FEEDBACK`, etc.)

---

## Tech Stack

| Component | Technology |
|-----------|-----------|
| Language | C# |
| Framework | .NET Framework 4.8 |
| UI | Windows Forms (WinForms) |
| Database | Oracle Database Express Edition (XE) 21c |
| Data Access | ADO.NET |
| IDE | Visual Studio 2022 |
| OS | Windows |

---

## Setup and Running

### Prerequisites

- Windows OS
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload
- [Oracle Database XE 21c](https://www.oracle.com/database/technologies/xe-downloads.html) installed and running
- SQL*Plus or Oracle SQL Developer (for schema setup)

### 1 — Set up the Database

Connect to your Oracle instance as SYSTEM or your schema user:

```sql
-- In SQL*Plus or SQL Developer:
@path\to\database\schema.sql
@path\to\database\seed.sql
```

This creates all tables, sequences, triggers, and views, then loads sample data.

### 2 — Configure the Connection String

Open `App.config` inside the Visual Studio project and add your Oracle connection string inside `<configuration>`:

```xml
<connectionStrings>
  <add name="HospitalDB"
       connectionString="Data Source=localhost:1521/XEPDB1;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
       providerName="Oracle.ManagedDataAccess.Client" />
</connectionStrings>
```

Replace `YOUR_USER` and `YOUR_PASSWORD` with your Oracle credentials.

### 3 — Build and Run

1. Open `DATABASE SYSTEMS PROJECT (PHASE # 2).sln` in Visual Studio 2022
2. Build the solution: **Build → Build Solution** (or `Ctrl+Shift+B`)
3. Run with **F5** — the application starts at the **Login Form**

---

## Forms Overview

| File | Class | Purpose |
|------|-------|---------|
| `Program.cs` | — | Entry point; launches `LoginForm` |
| `LoginForm.cs` | `LoginForm` | Unified login with role selection (Patient / Admin / Employee) |
| `SignupForm.cs` | `SignupForm` | New patient registration |
| `PatientFuncForm.cs` | `PatientFuncForm` | Patient dashboard |
| `AdminFuncForm.cs` | `AdminFuncForm` | Admin dashboard |
| `AdminManageAppointmentsForm.cs` | `AdminManageAppointmentsForm` | Admin — add/update/cancel appointments |
| `AdminManageEmployeeForm.cs` | `AdminManageEmployeeForm` | Admin — add/remove/update employees |
| `AdminGenerateReportsForm.cs` | `AdminGenerateReportsForm` | Admin — generate daily/weekly/monthly reports |
| `EmployeeFuncFormDN.cs` | `EmployeeFuncFormDN` | Doctor/Nurse dashboard |
| `EmployeeFuncFormRC.cs` | `EmployeeFuncFormRC` | Receptionist/Cashier dashboard |
| `CustomerSupportStaffForm.cs` | `CustomerSupportStaffForm` | Customer support staff dashboard |

---

## Current Status (Phase 2)

This is Phase 2 of the semester project. The UI layer is complete with all dashboards, sidebars, and navigation structure in place. Database connectivity (ADO.NET queries wiring the forms to Oracle) is the next implementation phase.

| Component | Status |
|-----------|--------|
| UI shell for all 10 forms | Complete |
| Oracle database schema | Complete |
| Sample seed data | Complete |
| Database connectivity (ADO.NET) | Pending — next phase |
| Authentication logic | Pending |
| Full CRUD operations per form | Pending |

---

## Known Issues Fixed

- `Program.cs` previously opened `AdminGenerateReportsForm` directly, bypassing the login screen. Fixed to open `LoginForm`.
- Three form files (`GenerateReportForm`, `ManageAppointmentsForm`, `ManageEmployeeForm`) had filenames inconsistent with their class names. All renamed to match (`AdminGenerateReportsForm`, `AdminManageAppointmentsForm`, `AdminManageEmployeeForm`) and the `.csproj` updated accordingly.
