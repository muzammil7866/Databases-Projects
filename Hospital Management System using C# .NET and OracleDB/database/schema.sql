-- ============================================================
-- Hospital Management System — Database Schema
-- Course   : CL2005 – Database Systems (Semester Project Phase 2)
-- Student  : Muzammil Bin Sohail  |  Roll No: 22F-3110
-- Section  : BSAI-4A1
-- Database : Oracle Database Express Edition (XE)
-- ============================================================

-- ============================================================
-- SEQUENCES  (Oracle uses sequences for auto-increment PKs)
-- ============================================================

CREATE SEQUENCE patient_seq       START WITH 1 INCREMENT BY 1 NOCACHE;
CREATE SEQUENCE employee_seq      START WITH 1 INCREMENT BY 1 NOCACHE;
CREATE SEQUENCE appointment_seq   START WITH 1 INCREMENT BY 1 NOCACHE;
CREATE SEQUENCE prescription_seq  START WITH 1 INCREMENT BY 1 NOCACHE;
CREATE SEQUENCE medical_rec_seq   START WITH 1 INCREMENT BY 1 NOCACHE;
CREATE SEQUENCE feedback_seq      START WITH 1 INCREMENT BY 1 NOCACHE;
CREATE SEQUENCE task_seq          START WITH 1 INCREMENT BY 1 NOCACHE;
CREATE SEQUENCE report_seq        START WITH 1 INCREMENT BY 1 NOCACHE;

-- ============================================================
-- TABLE: PATIENTS
-- Stores all registered patient accounts (created via SignupForm).
-- ============================================================

CREATE TABLE PATIENTS (
    patient_id      NUMBER          CONSTRAINT pk_patients PRIMARY KEY,
    name            VARCHAR2(100)   NOT NULL,
    email           VARCHAR2(150)   NOT NULL CONSTRAINT uq_patient_email UNIQUE,
    password_hash   VARCHAR2(255)   NOT NULL,
    phone           VARCHAR2(20),
    id_proof        VARCHAR2(50),
    address         VARCHAR2(255),
    date_of_birth   DATE,
    created_at      DATE            DEFAULT SYSDATE NOT NULL
);

-- ============================================================
-- TABLE: EMPLOYEES
-- Covers all staff roles: Doctor, Nurse, Receptionist,
-- Cashier, CustomerSupport, Admin.
-- ============================================================

CREATE TABLE EMPLOYEES (
    employee_id     NUMBER          CONSTRAINT pk_employees PRIMARY KEY,
    name            VARCHAR2(100)   NOT NULL,
    email           VARCHAR2(150)   NOT NULL CONSTRAINT uq_employee_email UNIQUE,
    password_hash   VARCHAR2(255)   NOT NULL,
    phone           VARCHAR2(20),
    role            VARCHAR2(20)    NOT NULL
                        CONSTRAINT chk_emp_role CHECK (
                            role IN ('Doctor','Nurse','Receptionist',
                                     'Cashier','CustomerSupport','Admin')
                        ),
    department      VARCHAR2(50),
    salary          NUMBER(10,2)    CONSTRAINT chk_salary CHECK (salary >= 0),
    hire_date       DATE            DEFAULT SYSDATE NOT NULL,
    status          VARCHAR2(10)    DEFAULT 'Active'
                        CONSTRAINT chk_emp_status CHECK (status IN ('Active','Inactive'))
);

-- ============================================================
-- TABLE: APPOINTMENTS
-- Booked by patients (PatientFuncForm) and managed by
-- admins (AdminManageAppointmentsForm) and doctors
-- (EmployeeFuncFormDN).
-- ============================================================

CREATE TABLE APPOINTMENTS (
    appointment_id      NUMBER          CONSTRAINT pk_appointments PRIMARY KEY,
    patient_id          NUMBER          NOT NULL,
    doctor_id           NUMBER          NOT NULL,
    appointment_date    DATE            NOT NULL,
    appointment_time    VARCHAR2(10)    NOT NULL,
    status              VARCHAR2(15)    DEFAULT 'Scheduled'
                            CONSTRAINT chk_appt_status CHECK (
                                status IN ('Scheduled','Completed','Cancelled')
                            ),
    notes               VARCHAR2(500),
    created_at          DATE            DEFAULT SYSDATE NOT NULL,
    CONSTRAINT fk_appt_patient  FOREIGN KEY (patient_id)
        REFERENCES PATIENTS(patient_id) ON DELETE CASCADE,
    CONSTRAINT fk_appt_doctor   FOREIGN KEY (doctor_id)
        REFERENCES EMPLOYEES(employee_id)
);

-- ============================================================
-- TABLE: MEDICAL_RECORDS
-- Written by doctors after consultations.
-- Viewed by doctors via EmployeeFuncFormDN.
-- ============================================================

CREATE TABLE MEDICAL_RECORDS (
    record_id       NUMBER          CONSTRAINT pk_medical_records PRIMARY KEY,
    patient_id      NUMBER          NOT NULL,
    doctor_id       NUMBER          NOT NULL,
    diagnosis       VARCHAR2(500),
    treatment       VARCHAR2(500),
    visit_date      DATE            DEFAULT SYSDATE NOT NULL,
    notes           VARCHAR2(1000),
    CONSTRAINT fk_rec_patient   FOREIGN KEY (patient_id)
        REFERENCES PATIENTS(patient_id) ON DELETE CASCADE,
    CONSTRAINT fk_rec_doctor    FOREIGN KEY (doctor_id)
        REFERENCES EMPLOYEES(employee_id)
);

-- ============================================================
-- TABLE: PRESCRIPTIONS
-- Generated by doctors (EmployeeFuncFormDN → Generate
-- Prescriptions). Linked to a specific appointment.
-- ============================================================

CREATE TABLE PRESCRIPTIONS (
    prescription_id     NUMBER          CONSTRAINT pk_prescriptions PRIMARY KEY,
    appointment_id      NUMBER          NOT NULL,
    patient_id          NUMBER          NOT NULL,
    doctor_id           NUMBER          NOT NULL,
    medication          VARCHAR2(255)   NOT NULL,
    dosage              VARCHAR2(100),
    instructions        VARCHAR2(500),
    issued_date         DATE            DEFAULT SYSDATE NOT NULL,
    CONSTRAINT fk_pres_appt     FOREIGN KEY (appointment_id)
        REFERENCES APPOINTMENTS(appointment_id),
    CONSTRAINT fk_pres_patient  FOREIGN KEY (patient_id)
        REFERENCES PATIENTS(patient_id) ON DELETE CASCADE,
    CONSTRAINT fk_pres_doctor   FOREIGN KEY (doctor_id)
        REFERENCES EMPLOYEES(employee_id)
);

-- ============================================================
-- TABLE: FEEDBACK
-- Submitted by patients (PatientFuncForm → Feedback Section).
-- Viewed and resolved by CustomerSupportStaffForm.
-- ============================================================

CREATE TABLE FEEDBACK (
    feedback_id     NUMBER          CONSTRAINT pk_feedback PRIMARY KEY,
    patient_id      NUMBER          NOT NULL,
    feedback_text   VARCHAR2(2000)  NOT NULL,
    submitted_at    DATE            DEFAULT SYSDATE NOT NULL,
    status          VARCHAR2(10)    DEFAULT 'Pending'
                        CONSTRAINT chk_fb_status CHECK (status IN ('Pending','Resolved')),
    resolved_by     NUMBER,
    resolved_at     DATE,
    CONSTRAINT fk_fb_patient    FOREIGN KEY (patient_id)
        REFERENCES PATIENTS(patient_id) ON DELETE CASCADE,
    CONSTRAINT fk_fb_resolver   FOREIGN KEY (resolved_by)
        REFERENCES EMPLOYEES(employee_id)
);

-- ============================================================
-- TABLE: TASKS
-- Assigned to Receptionist/Cashier staff.
-- Managed via EmployeeFuncFormRC → Manage Tasks.
-- ============================================================

CREATE TABLE TASKS (
    task_id             NUMBER          CONSTRAINT pk_tasks PRIMARY KEY,
    employee_id         NUMBER          NOT NULL,
    task_description    VARCHAR2(500)   NOT NULL,
    assigned_date       DATE            DEFAULT SYSDATE NOT NULL,
    due_date            DATE,
    status              VARCHAR2(15)    DEFAULT 'Pending'
                            CONSTRAINT chk_task_status CHECK (
                                status IN ('Pending','InProgress','Completed')
                            ),
    CONSTRAINT fk_task_employee FOREIGN KEY (employee_id)
        REFERENCES EMPLOYEES(employee_id) ON DELETE CASCADE
);

-- ============================================================
-- TABLE: REPORTS
-- Generated by admins (AdminGenerateReportsForm) for daily,
-- weekly, or monthly hospital activity summaries.
-- ============================================================

CREATE TABLE REPORTS (
    report_id       NUMBER          CONSTRAINT pk_reports PRIMARY KEY,
    generated_by    NUMBER          NOT NULL,
    report_type     VARCHAR2(10)    NOT NULL
                        CONSTRAINT chk_report_type CHECK (
                            report_type IN ('Daily','Weekly','Monthly')
                        ),
    report_date     DATE            NOT NULL,
    generated_at    DATE            DEFAULT SYSDATE NOT NULL,
    summary         VARCHAR2(4000),
    CONSTRAINT fk_report_admin  FOREIGN KEY (generated_by)
        REFERENCES EMPLOYEES(employee_id)
);

-- ============================================================
-- TRIGGERS  (auto-populate PKs from sequences on INSERT)
-- ============================================================

CREATE OR REPLACE TRIGGER trg_patients_pk
    BEFORE INSERT ON PATIENTS
    FOR EACH ROW
BEGIN
    :NEW.patient_id := patient_seq.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER trg_employees_pk
    BEFORE INSERT ON EMPLOYEES
    FOR EACH ROW
BEGIN
    :NEW.employee_id := employee_seq.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER trg_appointments_pk
    BEFORE INSERT ON APPOINTMENTS
    FOR EACH ROW
BEGIN
    :NEW.appointment_id := appointment_seq.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER trg_prescriptions_pk
    BEFORE INSERT ON PRESCRIPTIONS
    FOR EACH ROW
BEGIN
    :NEW.prescription_id := prescription_seq.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER trg_medical_records_pk
    BEFORE INSERT ON MEDICAL_RECORDS
    FOR EACH ROW
BEGIN
    :NEW.record_id := medical_rec_seq.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER trg_feedback_pk
    BEFORE INSERT ON FEEDBACK
    FOR EACH ROW
BEGIN
    :NEW.feedback_id := feedback_seq.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER trg_tasks_pk
    BEFORE INSERT ON TASKS
    FOR EACH ROW
BEGIN
    :NEW.task_id := task_seq.NEXTVAL;
END;
/

CREATE OR REPLACE TRIGGER trg_reports_pk
    BEFORE INSERT ON REPORTS
    FOR EACH ROW
BEGIN
    :NEW.report_id := report_seq.NEXTVAL;
END;
/

-- ============================================================
-- VIEWS  (useful for application queries)
-- ============================================================

-- Full appointment details (joins patient and doctor names)
CREATE OR REPLACE VIEW V_APPOINTMENT_DETAILS AS
SELECT
    a.appointment_id,
    p.name              AS patient_name,
    p.email             AS patient_email,
    e.name              AS doctor_name,
    e.department        AS department,
    a.appointment_date,
    a.appointment_time,
    a.status,
    a.notes,
    a.created_at
FROM APPOINTMENTS a
JOIN PATIENTS  p ON a.patient_id = p.patient_id
JOIN EMPLOYEES e ON a.doctor_id  = e.employee_id;

-- Active employees by role
CREATE OR REPLACE VIEW V_ACTIVE_EMPLOYEES AS
SELECT
    employee_id, name, email, phone,
    role, department, salary, hire_date
FROM EMPLOYEES
WHERE status = 'Active';

-- Pending feedback with patient name
CREATE OR REPLACE VIEW V_PENDING_FEEDBACK AS
SELECT
    f.feedback_id,
    p.name          AS patient_name,
    f.feedback_text,
    f.submitted_at
FROM FEEDBACK f
JOIN PATIENTS p ON f.patient_id = p.patient_id
WHERE f.status = 'Pending'
ORDER BY f.submitted_at ASC;

-- Prescriptions with full context
CREATE OR REPLACE VIEW V_PRESCRIPTION_DETAILS AS
SELECT
    pr.prescription_id,
    p.name          AS patient_name,
    e.name          AS doctor_name,
    pr.medication,
    pr.dosage,
    pr.instructions,
    pr.issued_date,
    a.appointment_date
FROM PRESCRIPTIONS pr
JOIN PATIENTS      p ON pr.patient_id     = p.patient_id
JOIN EMPLOYEES     e ON pr.doctor_id      = e.employee_id
JOIN APPOINTMENTS  a ON pr.appointment_id = a.appointment_id;
