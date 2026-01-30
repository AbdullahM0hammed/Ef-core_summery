# 📚 Library Management System (LMS)

## 1. Overview
The **Library Management System (LMS)** is designed to manage books, categories, authors, members, loans, and fines in an efficient and structured way.

### Key Features
- Structured organization of books by **categories** and **authors**
- Easy **member registration** and tracking
- Automated **borrowing and returning** of books
- Automatic **fine calculation** for overdue or damaged books

### System Behavior
- Members can search books by **title**, **author**, or **category**
- When borrowing a book, a **due date** is assigned (e.g. 14 days from loan date)
- No fine is applied if the book is returned on time
- If overdue or damaged, a **fine is calculated automatically** upon return
- If fines remain unpaid, the member status may be set to **Suspended**

---

## 2. Entities & Their Details

### 2.1 Book
Represents a book in the library.

**Attributes**
- `Id` – Unique identifier  
- `Title` – Book title  
- `Price` – Book price  
- `PublicationYear` – Year of publication  
- `AvailableCopies` – Number of available copies  
- `TotalCopies` – Total number of copies  

**Relationships**
- One Book → One Author  
- One Book → One Category  
- One Book → Many Loans  

---

### 2.2 Category
Represents a book category.

**Attributes**
- `Id` – Unique identifier  
- `Title` – Category name  
- `Description` – Category details  

**Relationships**
- One Category → Many Books  

---

### 2.3 Author
Represents a writer of one or more books.

**Attributes**
- `Id` – Unique identifier  
- `FirstName`  
- `LastName`  
- `DateOfBirth`  

**Relationships**
- One Author → Many Books  

---

### 2.4 Member
Represents a registered library member.

**Attributes**
- `Id` – Unique identifier  
- `Name`  
- `Email`  
- `PhoneNumber`  
- `Address`  
- `MembershipDate`  
- `Status` (Active, Suspended)

**Relationships**
- One Member → Many Loans  

---

### 2.5 Loan
Represents a borrowing/returning transaction.

**Attributes**
- `Id` – Unique identifier  
- `LoanDate` – Borrowing date  
- `Status` (Borrowed, Returned, Overdue)  
- `DueDate` – Expected return date  
- `ReturnDate` – Actual return date  

**Relationships**
- One Loan → One Fine (if overdue)

---

### 2.6 Fine
Represents the money charged for overdue or damaged books.

**Attributes**
- `Id` – Unique identifier  
- `Amount` – Fine amount  
- `IssuedDate` – Fine issue date  
- `PaidDate` – Payment date  
- `Status` (Pending, Paid)

**Relationships**
- One Fine → One Loan  

---

## 3. Class Diagram
📌 *Illustrates the relationships between Book, Author, Category, Member, Loan, and Fine.*

---

## 4. Model Configurations

### 4.1 Book
| Property | Configuration |
|--------|---------------|
| Title | Varchar (Max 50) |
| Price | Decimal (6,2) |
| PublicationYear | From 1950 to Current Year |
| AvailableCopies | ≤ TotalCopies |

### 4.2 Category
| Property | Configuration |
|--------|---------------|
| Title | Varchar (Max 50) |
| Description | Varchar (Max 100) |

### 4.3 Author
| Property | Configuration |
|--------|---------------|
| FirstName | Varchar (Max 20) |
| LastName | Varchar (Max 20) |

### 4.4 Member
| Property | Configuration |
|--------|---------------|
| Name | Varchar (Max 50) |
| Email | Varchar (Max 100) – Valid Email |
| PhoneNumber | Varchar (Max 11) – Egyptian format |
| Address | Varchar (Max 100) |
| MembershipDate | Default insertion date |
| Status | Stored as label |

### 4.5 Loan
| Property | Configuration |
|--------|---------------|
| LoanDate | Default insertion date |
| Status | Stored as label |

### 4.6 Fine
| Property | Configuration |
|--------|---------------|
| Amount | Decimal (6,2) |
| IssuedDate | Default insertion date |
| Status | Stored as label |

---

## 5. ER Diagram
📌 *Shows entity relationships and constraints.*

---

## 6. Database Schema
📌 *Defines tables, keys, and constraints.*

---

## 7. Database Diagram
📌 *Visual representation of database tables.*

---

## 8. Data Seed

### 8.1 Authors
🔗 https://drive.google.com/file/d/1btBhQKUntkndL-tMpc4br_FwpbGaKOpZ/view

### 8.2 Categories
🔗 https://drive.google.com/file/d/1Rykot40B5avu5ocXvx_XKR0UPypSiURS/view

### 8.3 Books
🔗 https://drive.google.com/file/d/1PB2nGkN-0gi1rHgE5M5iK7rcQU0HsfHN/view

### 8.4 Members
🔗 https://drive.google.com/file/d/1kLFK8EC9DY1-74h1qHRyvPKhZTcYKwAK/view

---

## 9. Data Manipulation Examples

1. Retrieve book title, category title, and author full name for books with price > 300  
2. Retrieve all authors and their books (if any)  
3. Member with ID = 1 borrows Book with ID = 2 and returns it after 5 days  
4. After 10 days, Member with ID = 1 returns the book  
5. Retrieve all members who currently have active loans  

---

## 🛠 Technologies Used
- C#
- .NET
- Entity Framework Core
- SQL Server

---

## 👤 Author
**Abdullah**
