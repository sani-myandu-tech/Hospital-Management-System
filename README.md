# 🏥 Lifeline Hospital Management System
### 2nd Year Project| ISTN212 Assignment | C# Windows Forms + SQL Server

![Platform](https://img.shields.io/badge/Platform-Windows-blue)
![Language](https://img.shields.io/badge/Language-C%23-purple)
![Database](https://img.shields.io/badge/Database-SQL%20Server-red)
![Framework](https://img.shields.io/badge/.NET-Framework%204.7.2-blueviolet)
![Status](https://img.shields.io/badge/Status-Complete-brightgreen)

> A fully functional hospital management desktop application that allows administrators and doctors to manage patients, appointments, medical records, and departments through a role-based login system.

---

## 📋 Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [System Requirements](#system-requirements)
- [Setup & Installation](#setup--installation)
- [How to Use](#how-to-use)
- [Database Structure](#database-structure)
- [Screenshots](#screenshots)
- [Author](#author)

---

## 📌 Overview

Lifeline Hospital Management System is a desktop application built for ISTN212. It solves the problem of manual hospital record keeping by providing a centralised system where:

- **Admins** manage patients, doctors, appointments, departments, and medical records
- **Doctors** view their appointments and access medical records through a dedicated portal

The system uses role-based access control — the same login form routes users to different dashboards based on their position in the database.

---

## ✅ Features

### 🔐 Authentication
- Secure login with password validation (length, uppercase, lowercase, number, special character)
- Show/hide password toggle
- Role-based routing — Admin → HomePage, Doctor → Doctor Home
- Session management across all forms
- Logout with confirmation on all pages

### 🏠 Splash Screen
- Custom animated loading screen with rotating arc loader
- Smooth fade-in and fade-out transitions
- Auto-navigates to Login after 3 seconds

### 👤 Patient Management
- Add new patients with auto-generated IDs (PRN101, PRN102...)
- Update existing patient details
- Delete patients with confirmation
- View all patients in a data grid

### 👨‍⚕️ Doctor Management
- Add doctors with auto-generated IDs (D001, D002...)
- Update and delete doctor records
- Live search by doctor name as you type
- Search by Doctor ID

### 📅 Appointment Management
- Book appointments with time slots (8:00 AM – 4:00 PM, 30-min intervals)
- Update and cancel appointments
- Status tracking (Scheduled, Completed, Cancelled)
- Open booking form for detailed scheduling

### 🏢 Department Management
- Add departments with auto-generated IDs (DP01, DP02...)
- Update and delete departments
- Link departments to doctors

### 🗂️ Medical Records
- Create medical records linked to patients and doctors
- Auto-generated Record IDs (R001, R002...)
- Update and delete records
- Date-based record tracking

### 📊 Dashboard
- Live statistics: Total Patients, Today's Appointments, Total Doctors, Completed Today
- Data grids showing today's appointments and recent patients
- Auto-refresh timer

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| UI Framework | Windows Forms |
| Database | Microsoft SQL Server |
| ORM / Data Access | ADO.NET — TableAdapters, DataSet |
| IDE | Visual Studio 2022 |
| Target Framework | .NET Framework 4.7.2 |

---

## 💻 System Requirements

- Windows 10 or 11
- Visual Studio 2019 or later
- SQL Server Express or full SQL Server
- SQL Server Management Studio (SSMS)
- .NET Framework 4.7.2

---

## ⚙️ Setup & Installation

### 1. Clone or download the repository
```bash
git clone https://github.com/sani-mnyandu-tech/Assignment212.git
```
Or click **Code → Download ZIP** and extract it.

### 2. Set up the database
- Open **SQL Server Management Studio (SSMS)**
- Connect to your SQL Server instance
- Create a new database called `ist2ib`:
```sql
CREATE DATABASE ist2ib;
```
- Run the table creation scripts to set up all required tables

### 3. Update the connection string
- Open `App.config` in the project
- Find the `connectionStrings` section
- Update `Data Source` to match your SQL Server instance name:
```xml
<add name="Assignment212.Properties.Settings.ist2ibConnectionString"
     connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=ist2ib;Integrated Security=True"
     providerName="System.Data.SqlClient" />
```

### 4. Open and run
- Open `Assignment212.sln` in Visual Studio
- Press **F5** or click **Start** to build and run

---

## 🖥️ How to Use

### Logging In
- Enter your username and password
- Password must be at least 8 characters with uppercase, lowercase, number, and special character
- Admin users are routed to the **HomePage**
- Doctor users are routed to **Doctor Home**

### Admin Dashboard (HomePage)
Navigate using the sidebar labels:
| Label | Opens |
|---|---|
| Patients | Patient management form |
| Doctors | Doctor management form |
| Appointments | Appointment management form |
| Departments | Department management form |
| Medical Records | Medical records form |
| Dashboard | Live statistics dashboard |

### Doctor Portal (Doctor Home)
- View assigned appointments
- Access medical records
- View dashboard statistics
- Welcome message displays the logged-in doctor's name

---

## 🗄️ Database Structure

| Table | Key Columns |
|---|---|
| `LOGIN_USERS` | UserID, Username, Password, Position |
| `PATIENTS` | PatientID, Name, CellNo, Email, Gender, Address |
| `DOCTOR` | DoctorID, DoctorName, Specialization, CellNo, Email |
| `APPOINTMENTS` | AppointmentID, PatientID, DoctorID, AppointmentDate, AppointmentTime, Status |
| `DEPARTMENTS` | DepartmentID, DepartmentName, DepartmentHead, DoctorID |
| `MEDICAL_RECORDS` | RecordID, PatientID, DoctorID, DateRecord |

---

## 📸 Screenshots
Coming just now!!

| Screen | Description |
|---|---|
| Splash Screen | Animated loading screen with rotating arc |
| Login | Password validation with show/hide toggle |
| HomePage | Admin dashboard with image slideshow |
| Doctor Home | Doctor portal with welcome message |
| Patient Form | Full CRUD with auto-ID generation |
| Dashboard | Live statistics and data grids |

---

## 🔍 Sample SQL Queries

```sql
-- Show all patients
SELECT * FROM PATIENTS;

-- Get appointments for a specific date
SELECT * FROM APPOINTMENTS WHERE AppointmentDate = '2025-01-01';

-- Patients who have visited more than once
SELECT PatientID, COUNT(*) AS TotalAppointments
FROM APPOINTMENTS
GROUP BY PatientID
HAVING COUNT(*) > 1;

-- Appointment count per doctor
SELECT D.DoctorName, COUNT(A.AppointmentID) AS TotalAppointments
FROM DOCTOR D
LEFT JOIN APPOINTMENTS A ON D.DoctorID = A.DoctorID
GROUP BY D.DoctorName
ORDER BY TotalAppointments DESC;
```

---

## 👤 Author

**Lungisani Mnyandu**  
ISTN212 | Information Systems  


---

*Built as part of ISTN212 coursework — University of KwaZulu-Natal*
