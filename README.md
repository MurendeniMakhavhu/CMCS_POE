 Contract Monthly Claim System (CMCS)

A WPF-based .NET Framework application for managing Independent Contractor (IC) lecturer monthly claims.

---

 Overview
The **Contract Monthly Claim System (CMCS)** streamlines the process of submitting, approving, and tracking lecturer claims.  
It is built using **C# (.NET Framework, WPF)** with **SQL Server** as the backend database.

---

 Features Implemented
 Lecturer Portal
- Submit new claims (hours, rate, supporting document)
- Upload PDF/DOCX/XLSX files
- View claim submission status

 Coordinator Portal
- View all pending claims
- Approve or Reject claims
- Refresh claim list dynamically
- Return to main dashboard

 Database
- SQL Server via Entity Framework (.edmx)
- Claims table includes:
  - `ClaimID`, `LecturerName`, `HoursWorked`, `HourlyRate`, `Status`, `SupportingDocumentPath`

---

 Technology Stack
| Component | Technology |
|------------|-------------|
| Framework | .NET Framework (WPF) |
| Language | C# |
| Database | SQL Server (SSMS) |
| ORM | Entity Framework (.edmx model) |
| IDE | Visual Studio 2022 |
| Version Control | GitHub |

---

 Folder Structure
```
CMCS_WPF_Framework/
│
├── App.config
├── MainWindow.xaml
├── LecturerPortal.xaml
├── CoordinatorPortal.xaml
├── LecturerClaimForm.xaml
├── ClaimStatusWindow.xaml
├── Models/
│   └── CMCSModel.edmx
├── Uploads/
│   └── (Uploaded files stored here)
└── README.md
```

---

 Setup Instructions
1. Clone the repository from GitHub.  
2. Open the `.sln` file in **Visual Studio**.  
3. Update your **SQL Server connection string** in `App.config`.  
4. Run the application (F5).  
5. Use:
   - **Lecturer Portal** → Submit claims  
   - **Coordinator Portal** → Approve/Reject claims  

---

 Version Control Summary
At least 5 commits were made during development:
1. Initial WPF project structure  
2. Added database and Entity Framework  
3. Implemented Lecturer claim submission  
4. Implemented Coordinator approval/rejection  
5. Added Claim Status and Refresh features  

---

 Developer
Student Name: Murendeni Makhavhu  
Module: PROG6212 — Programming 2B  
Project: Contract Monthly Claim System (CMCS)

---

