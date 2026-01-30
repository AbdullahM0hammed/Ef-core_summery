namespace Ef_core_summery
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
#region over view 
/*
    1. Overview
The Library Management System (LMS) is designed to manage books, categories, authors, members, loans, and fines in an efficient and structured way.
It provides:
●	A structured way to organize books by categories and authors.
●	Easy registration and tracking of members.
●	Automated borrowing and returning of books.
●	Fine calculation for overdue or damaged items.
System Behavior:
●	The system should allow members to search books by title, author, or category.
●	When borrowing, the system should assign a due date (e.g., 14 days from loan date).
●	If the book is returned on time, no fine is applied.
●	If the book is overdue or damaged, the system should automatically calculate and issue a fine when the book is returned.
●	If fines remain unpaid, the member’s account status may be set to Suspended.
 
2. Entities & Their Details
2.1 Book ( Represents a book in the library )
Attributes:
●	 Id  – Unique identifier
●	Title – Title of the book
●	Price - the Book Price
●	 PublicationYear – Year of publication
●	AvailableCopies – Number of available copies
●	TotalCopies – Total number of copies in the library
Relationships:
●	One book → One author
●	One book → Many loans
●	One book → One Category (Each book must belong to one category)

2.2 Category ( Represents a category for books )
Attributes:
●	Id – Unique identifier
●	Title - Name of the category
●	Description - Category details
Relationships:
●	One Category → Many books (Each Book Must Belong To One Category)

2.3 Author ( Represents a writer of one or more books )
Attributes:
●	Id – Unique identifier
●	FirstName
●	LastName
●	DateOfBirth
Relationships:
One author → Many books (Each Book Must Belong To One Author)

2.4 Member ( Represents a registered library member )
Attributes:
●	Id – Unique identifier
●	Name
●	Email
●	PhoneNumber
●	Address
●	MembershipDate
●	Status (Active, Suspended)
Relationships:
●	One member → Many loans (One Member Can Loan Many Books)
2.5 Loan ( Represents a borrowing/returning transaction)
Attributes:
●	Id – Unique identifier
●	LoanDate – Date when book was borrowed
●	Status (Borrowed, Returned, Overdue)
Relationships:
●	When a member borrows a book, the system should store the following data :
○	DueDate – Expected return date
○	ReturnDate –  Actual return date
●	One Fine → One Loan (if the member exceeds the due date )
2.6 Fine ( Represents the money charged for overdue or damaged books )
Attributes:
●	Id – Unique identifier
●	Amount – the fine amount
●	IssuedDate – Date when fine was issued
●	PaidDate – Date when fine was paid
●	Status ( Pending, Paid)
Relationships:
●	One Fine → One Loan
3. Class Diagram
4. Model Configurations 
4.1 Book
Property 
Configuration 
Tittle 	Varchar With Max Length 50
Price	Stored as a decimal with 6 digits in total and 2 digits after the decimal point
PublicationYear	From 1950 To Current Year
AvailableCopies	Equals Or Less Than TotalCopies
4.2 Category
Property 
Configuration 
Tittle 	Varchar With Max Length 50
Description	Varchar With Max Length 100
4.3 Author 
Property 
Configuration 
FirstName	Varchar With Max Length 20
LastName	Varchar With Max Length 20
4.4 Member 
Property 
Configuration 
Name	Varchar With Max Length 50
Email	Varchar With Max Length 100 With Valid Format Of Email
PhoneNumber	Varchar With Max Length 11 With Valid Format Of Egyptian Phone Number
Address	Varchar With Max Length 100
MembershipDate	Default Value Insertion Date
Status	Store Label instead of Label value 
4.5 Loan
Property 
Configuration 
LoanDate	Default Value Insertion Date
Status	Store Label instead of Label value 
4.6 Fine
Property 
Configuration 
Amount	Stored as a decimal with 6 digits in total and 2 digits after the decimal point
IssuedDate	Default Value Insertion Date
Status	Store Label instead of Label value 
5. ER diagram
6. Database Schema 
7. Database Diagram 
------>First_class_digramcd.cd
8. Data Seed
8.1 Authors
https://drive.google.com/file/d/1btBhQKUntkndL-tMpc4br_FwpbGaKOpZ/view?usp=drive_link 
8.2 Categories
https://drive.google.com/file/d/1Rykot40B5avu5ocXvx_XKR0UPypSiURS/view?usp=drive_link 
8.3 Books
https://drive.google.com/file/d/1PB2nGkN-0gi1rHgE5M5iK7rcQU0HsfHN/view?usp=drive_link 
8.4 Members
https://drive.google.com/file/d/1kLFK8EC9DY1-74h1qHRyvPKhZTcYKwAK/view?usp=drive_link 
9. Data Manipulation 

1.	 Retrieve the book title, its category title , and the author’s full name for all books whose price is greater than 300.
2.	Retrieve All Authors And His/Her Books if Exists. 
3.	Member with id 1 Want To Borrow The Book With Id 2 And He Will Return it After 5 Days 
4.	After 10 Days Member with id 1 Returned The Book
5.	Retrieve all members who currently have active loans (i.e., loans that have not yet been returned)
 */
#endregion