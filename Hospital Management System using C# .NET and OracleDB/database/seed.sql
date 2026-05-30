-- ============================================================
-- Hospital Management System — Sample / Seed Data
-- Run schema.sql first before executing this file.
-- ============================================================

-- ============================================================
-- EMPLOYEES  (Admins, Doctors, Nurses, Receptionist, etc.)
-- NOTE: password_hash values here are placeholders.
--       In production use a proper hashing library (e.g. BCrypt).
-- ============================================================

INSERT INTO EMPLOYEES (name, email, password_hash, phone, role, department, salary)
VALUES ('Sara Khan',       'sara.khan@hms.com',      'hash_sara',       '0300-1111111', 'Admin',          'Administration',    85000);

INSERT INTO EMPLOYEES (name, email, password_hash, phone, role, department, salary)
VALUES ('Dr. Ahmed Ali',   'ahmed.ali@hms.com',      'hash_ahmed',      '0300-2222222', 'Doctor',         'Cardiology',        150000);

INSERT INTO EMPLOYEES (name, email, password_hash, phone, role, department, salary)
VALUES ('Dr. Hina Baig',   'hina.baig@hms.com',      'hash_hina',       '0300-3333333', 'Doctor',         'Neurology',         145000);

INSERT INTO EMPLOYEES (name, email, password_hash, phone, role, department, salary)
VALUES ('Nurse Ayesha',    'ayesha.nurse@hms.com',   'hash_ayesha',     '0300-4444444', 'Nurse',          'General Ward',      55000);

INSERT INTO EMPLOYEES (name, email, password_hash, phone, role, department, salary)
VALUES ('Bilal Receptionist', 'bilal.rec@hms.com',   'hash_bilal',      '0300-5555555', 'Receptionist',   'Front Desk',        45000);

INSERT INTO EMPLOYEES (name, email, password_hash, phone, role, department, salary)
VALUES ('Zara Cashier',    'zara.cashier@hms.com',   'hash_zara',       '0300-6666666', 'Cashier',        'Billing',           43000);

INSERT INTO EMPLOYEES (name, email, password_hash, phone, role, department, salary)
VALUES ('Omar Support',    'omar.support@hms.com',   'hash_omar',       '0300-7777777', 'CustomerSupport','Help Desk',         42000);

COMMIT;

-- ============================================================
-- PATIENTS
-- ============================================================

INSERT INTO PATIENTS (name, email, password_hash, phone, id_proof, address, date_of_birth)
VALUES ('Ali Hassan',      'ali.hassan@email.com',   'hash_ali',     '0311-1234567', 'CNIC-3520112345671', 'House 12, Lahore',       TO_DATE('1990-05-15','YYYY-MM-DD'));

INSERT INTO PATIENTS (name, email, password_hash, phone, id_proof, address, date_of_birth)
VALUES ('Fatima Malik',    'fatima.malik@email.com', 'hash_fatima',  '0321-9876543', 'CNIC-3520198765432', 'Flat 5B, Karachi',       TO_DATE('1995-11-22','YYYY-MM-DD'));

INSERT INTO PATIENTS (name, email, password_hash, phone, id_proof, address, date_of_birth)
VALUES ('Usman Tariq',     'usman.tariq@email.com',  'hash_usman',   '0333-5556677', 'CNIC-3310155566771', 'Street 7, Islamabad',    TO_DATE('1988-03-08','YYYY-MM-DD'));

INSERT INTO PATIENTS (name, email, password_hash, phone, id_proof, address, date_of_birth)
VALUES ('Sana Iqbal',      'sana.iqbal@email.com',   'hash_sana',    '0345-1122334', 'CNIC-3740111223341', 'Block C, Faisalabad',    TO_DATE('2000-07-30','YYYY-MM-DD'));

COMMIT;

-- ============================================================
-- APPOINTMENTS  (patient_id refs above: Ali=1, Fatima=2, Usman=3, Sana=4)
--               (doctor_id refs above: Dr. Ahmed=2, Dr. Hina=3)
-- ============================================================

INSERT INTO APPOINTMENTS (patient_id, doctor_id, appointment_date, appointment_time, status, notes)
VALUES (1, 2, TO_DATE('2024-06-10','YYYY-MM-DD'), '09:00 AM', 'Completed',  'Routine cardiac checkup');

INSERT INTO APPOINTMENTS (patient_id, doctor_id, appointment_date, appointment_time, status, notes)
VALUES (2, 3, TO_DATE('2024-06-11','YYYY-MM-DD'), '11:00 AM', 'Completed',  'Migraine follow-up');

INSERT INTO APPOINTMENTS (patient_id, doctor_id, appointment_date, appointment_time, status, notes)
VALUES (3, 2, TO_DATE('2024-06-15','YYYY-MM-DD'), '02:30 PM', 'Scheduled',  'Initial consultation');

INSERT INTO APPOINTMENTS (patient_id, doctor_id, appointment_date, appointment_time, status, notes)
VALUES (4, 3, TO_DATE('2024-06-15','YYYY-MM-DD'), '04:00 PM', 'Scheduled',  'Headache evaluation');

INSERT INTO APPOINTMENTS (patient_id, doctor_id, appointment_date, appointment_time, status, notes)
VALUES (1, 2, TO_DATE('2024-06-20','YYYY-MM-DD'), '10:00 AM', 'Cancelled',  'Patient cancelled');

COMMIT;

-- ============================================================
-- MEDICAL RECORDS  (for completed appointments)
-- ============================================================

INSERT INTO MEDICAL_RECORDS (patient_id, doctor_id, diagnosis, treatment, visit_date, notes)
VALUES (1, 2, 'Mild hypertension', 'Prescribed antihypertensives; lifestyle changes advised',
        TO_DATE('2024-06-10','YYYY-MM-DD'), 'BP: 145/90. Follow up in 4 weeks.');

INSERT INTO MEDICAL_RECORDS (patient_id, doctor_id, diagnosis, treatment, visit_date, notes)
VALUES (2, 3, 'Chronic migraine', 'Prescribed triptans; avoid known triggers',
        TO_DATE('2024-06-11','YYYY-MM-DD'), 'Frequency: 3-4 times/month. MRI normal.');

COMMIT;

-- ============================================================
-- PRESCRIPTIONS  (linked to completed appointments)
-- ============================================================

INSERT INTO PRESCRIPTIONS (appointment_id, patient_id, doctor_id, medication, dosage, instructions)
VALUES (1, 1, 2, 'Amlodipine', '5mg once daily', 'Take in the morning with water. Avoid grapefruit juice.');

INSERT INTO PRESCRIPTIONS (appointment_id, patient_id, doctor_id, medication, dosage, instructions)
VALUES (2, 2, 3, 'Sumatriptan', '50mg as needed', 'Take at onset of migraine. Do not exceed 2 doses in 24 hours.');

COMMIT;

-- ============================================================
-- FEEDBACK
-- ============================================================

INSERT INTO FEEDBACK (patient_id, feedback_text, status)
VALUES (1, 'The service was excellent. Dr. Ahmed was very thorough and professional.', 'Resolved');

INSERT INTO FEEDBACK (patient_id, feedback_text, status)
VALUES (2, 'Waiting time at reception was too long. Needs improvement.', 'Pending');

INSERT INTO FEEDBACK (patient_id, feedback_text, status)
VALUES (3, 'Clean and well-organised facility. Happy with my appointment.', 'Pending');

COMMIT;

-- ============================================================
-- TASKS  (for Receptionist and Cashier staff)
-- ============================================================

INSERT INTO TASKS (employee_id, task_description, due_date, status)
VALUES (5, 'Confirm all scheduled appointments for the week via phone call',
        TO_DATE('2024-06-14','YYYY-MM-DD'), 'Completed');

INSERT INTO TASKS (employee_id, task_description, due_date, status)
VALUES (5, 'Update patient registration records for new walk-ins',
        TO_DATE('2024-06-15','YYYY-MM-DD'), 'InProgress');

INSERT INTO TASKS (employee_id, task_description, due_date, status)
VALUES (6, 'Process outstanding billing invoices for June',
        TO_DATE('2024-06-20','YYYY-MM-DD'), 'Pending');

INSERT INTO TASKS (employee_id, task_description, due_date, status)
VALUES (6, 'Reconcile daily cash receipts with billing system',
        TO_DATE('2024-06-15','YYYY-MM-DD'), 'InProgress');

COMMIT;

-- ============================================================
-- REPORTS
-- ============================================================

INSERT INTO REPORTS (generated_by, report_type, report_date, summary)
VALUES (1, 'Daily', TO_DATE('2024-06-10','YYYY-MM-DD'),
        'Total appointments: 3 | Completed: 2 | Cancelled: 0 | Revenue: PKR 12,000');

INSERT INTO REPORTS (generated_by, report_type, report_date, summary)
VALUES (1, 'Weekly', TO_DATE('2024-06-10','YYYY-MM-DD'),
        'Week of June 10-16: Appointments: 12 | Patients seen: 9 | Feedback received: 3 | Revenue: PKR 58,500');

COMMIT;
