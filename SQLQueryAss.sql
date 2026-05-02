-- ============================================================
-- Assignment 212 — SQL Queries
-- Hospital Management System
-- ============================================================

-- 1. Show all patient details
SELECT * FROM PATIENTS;

-- 2. Update a doctor's specialisation
UPDATE DOCTOR
SET Specialization = 'Pediatrics'
WHERE DoctorID = 'D003';

-- 3. Show all appointments for a specific date
SELECT * FROM APPOINTMENTS
WHERE AppointmentDate = '2025-01-01';

-- 4. Show patients whose name starts with 'B'
SELECT * FROM PATIENTS
WHERE Name LIKE 'B%';

-- 5. Get all appointments within a date range (e.g. September 2025)
SELECT * FROM APPOINTMENTS
WHERE AppointmentDate BETWEEN '2025-09-01' AND '2025-09-30';

-- 6. Show patients who have an appointment with a specific doctor
SELECT Name, PatientID FROM PATIENTS
WHERE PatientID IN (
    SELECT PatientID FROM APPOINTMENTS
    WHERE DoctorID = 'D005'
);

-- 7. Show doctors who have an appointment on a specific date
SELECT DoctorName, DoctorID FROM DOCTOR
WHERE DoctorID IN (
    SELECT DoctorID FROM APPOINTMENTS
    WHERE AppointmentDate = '2025-09-28'
);

-- 8. Count total number of patients
SELECT COUNT(*) AS TotalPatients FROM PATIENTS;

-- 9. Show patients who have visited the hospital more than once
SELECT PatientID, COUNT(*) AS TotalAppointments
FROM APPOINTMENTS
GROUP BY PatientID
HAVING COUNT(*) > 1;

-- 10. Show appointment count per doctor (NEW — demonstrates GROUP BY with JOIN)
SELECT D.DoctorName, COUNT(A.AppointmentID) AS TotalAppointments
FROM DOCTOR D
LEFT JOIN APPOINTMENTS A ON D.DoctorID = A.DoctorID
GROUP BY D.DoctorName
ORDER BY TotalAppointments DESC;
