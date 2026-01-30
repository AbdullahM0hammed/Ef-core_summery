using Ef_core_summery.Contexts;
using Ef_core_summery.Helper;
namespace Ef_core_summery
{
internal class Program
    {
        static void Main(string[] args)
        {
            using LibararyDbContext dbContext = new LibararyDbContext ();
            #region seeding
            //bool res = LibararyDbContextSeed.SeedData(dbContext);
            //if (res)
            //{
            //    Console.WriteLine("Data Seeded Successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Data Seeding Failed or Already Seeded.");
            //}

            #endregion

            #region 1.Retrieve the book title, its category title

            //and the author’s full name for all books whose price is greater than 300.
            //var query = from book in dbContext.Books
            //                where book.Price > 300
            //                join category in dbContext.Categories
            //                    on book.CategoryID equals category.Id
            //                join author in dbContext.Authors
            //                    on book.AuthorID equals author.Id
            //                select new
            //                {
            //                    BookTitle = book.Title,
            //                    CategoryTitle = category.Title,
            //                    AuthorFullName = author.FirstName + " " + author.LastName
            //                };
            //    var results = query.ToList();
            //    foreach (var result in results)
            //    {
            //        Console.WriteLine($"Book: {result.BookTitle}, Category: {result.CategoryTitle}, Author: {result.AuthorFullName}");
            //    }
            //    var book = dbContext.Books.Where (b => b.Price > 300).Select (b => new
            //{
            //    BookTitel = b.Title,
            //    Categorytitel = b.BookCategory.Title,
            //    AuthorFullName = b.BookAuthor.FirstName + " " + b.BookAuthor.LastName
            //}).ToList();
            //    foreach (var b in book )
            //    {
            //        Console.WriteLine ($"Book: {b.BookTitel}, Category: {b.Categorytitel}, Author: {b.AuthorFullName}");
            //    } 
            #endregion

            #region 2 Retrieve All Authors And His/Her Books if Exists. 
            //var AuthorBook = dbContext.Authors.Include(x=> x.AuthoredBooks).ToList();
            //foreach (var author in AuthorBook)
            //{
            //    Console.WriteLine($"Author: {author.FirstName} {author.LastName}");
            //    if (author.AuthoredBooks != null && author.AuthoredBooks.Count > 0)
            //    {
            //        foreach (var book in author.AuthoredBooks)
            //        {
            //            Console.WriteLine($"\tBook: {book.Title}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\tNo books found for this author.");
            //    }
            //}

            //OR

            //var authorBooks = dbContext.Authors.Select(a => new
            //{
            //    AuthorName = a.FirstName + " " + a.LastName,
            //    Books = a.AuthoredBooks.Select(b => b.Title).ToList()
            //}).ToList();
            //foreach (var author in authorBooks)
            //{
            //    Console.WriteLine($"Author: {author.AuthorName}");
            //    if (author.Books.Any())
            //    {
            //        foreach (var bookTitle in author.Books)
            //        {
            //            Console.WriteLine($"\tBook: {bookTitle}");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("\tNo books found for this author.");
            //    }
            //}
            #endregion

            #region 3 Member with id 1 Want To Borrow The Book With Id 2 And He Will Return it After 5 Days 
            //int memberId = 2;
            //int bookId = 2;
            //int borrowDays = 5;
            //bool result = LoanMangement.BorrowBook(bookId, memberId, borrowDays, dbContext);
            //if (result)
            //{
            //    Console.WriteLine($"Member with ID {memberId} sucsess borrwing book with id {bookId} " +
            //        $"for {borrowDays} days  ");
            //}
            //else
            //{
            //    Console.WriteLine("Failed to borrow the book.");
            //}

            #endregion

            #region 1.After 10 Days Member with id 1 Returned The Book
            //int memberId = 2;
            //int bookId = 2;
            //bool returnResult = LoanMangement.ReturnBook(bookId, memberId, dbContext);
            //if (returnResult)
            //    Console.WriteLine($"Member with ID {memberId} successfully returned book with ID {bookId}.");
            //else
            //    Console.WriteLine("Failed to return the book.");
            #endregion

            #region 2.Retrieve all members who currently have active loans(i.e., loans that have not yet been returned)

            var memberswithactiveloans = dbContext.Members
                .Where(M=> dbContext.MemberLoans.Any(ML=>ML.MemberID==M.Id && ML.ReturnDate==null))
                .ToList();
            foreach (var member in memberswithactiveloans)
            {
                    Console.WriteLine($"Member ID: {member.Id}, Name: {member.Name}");
            }

            #endregion
        }
    }
}
