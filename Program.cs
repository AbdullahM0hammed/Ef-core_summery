

namespace Ef_core_summery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Overview.
            //            1.overview
            //the library management system(lms) is designed to manage books, categories, authors, members, loans, and fines in an efficient and structured way.
            //it provides:
            //●	a structured way to organize books by categories and authors.
            //●	easy registration and tracking of members.
            //●	automated borrowing and returning of books.
            //●	fine calculation for overdue or damaged items.
            //system behavior:
            //●	the system should allow members to search books by title, author, or category.
            //●	when borrowing, the system should assign a due date(e.g., 14 days from loan date).
            //●	if the book is returned on time, no fine is applied.
            //●	if the book is overdue or damaged, the system should automatically calculate and issue a fine when the book is returned.
            //●	if fines remain unpaid, the member’s account status may be set to suspended.
            //==========================================
            //2.entities & their details
            //2.1 book(represents a book in the library)
            //attributes:
            //●	 id  – unique identifier
            //●	title – title of the book
            //●	price - the book price
            //●	 publicationyear – year of publication
            //●	availablecopies – number of available copies
            //●	totalcopies – total number of copies in the library
            //relationships:
            //●	one book → one author
            //●	one book → many loans
            //●	one book → one category(each book must belong to one category)
            //-------------------------------------------
            //2.2 category(represents a category for books )
            //                attributes:
            //●	id – unique identifier
            //●	title - name of the category
            //●	description - category details
            //relationships:
            //●	one category → many books(each book must belong to one category)
            //-------------------------------------------
            //2.3 author(represents a writer of one or more books)
            //attributes:
            //●	id – unique identifier
            //●	firstname
            //●	lastname
            //●	dateofbirth
            //relationships:
            //one author → many books(each book must belong to one author)
            //-------------------------------------------
            //2.4 member(represents a registered library member)
            //attributes:
            //●	id – unique identifier
            //●	name
            //●	email
            //●	phonenumber
            //●	address
            //●	membershipdate
            //●	status(active, suspended)
            //relationships:
            //●	one member → many loans(one member can loan many books)
            //-------------------------------------------
            //2.5 loan(represents a borrowing / returning transaction)
            //attributes:
            //●	id – unique identifier
            //●	loandate – date when book was borrowed
            //●	status(borrowed, returned, overdue)
            //relationships:
            //●	when a member borrows a book, the system should store the following data :
            //○	duedate – expected return date
            //○	returndate –  actual return date
            //●	one fine → one loan(if the member exceeds the due date )
            //-------------------------------------------
            //2.6 fine(represents the money charged for overdue or damaged books)
            //            attributes:
            //●	id – unique identifier
            //●	amount – the fine amount
            //●	issueddate – date when fine was issued
            //●	paiddate – date when fine was paid
            //●	status(pending, paid)
            //relationships:
            //●	one fine → one loan
            #endregion

        }
    }
}
