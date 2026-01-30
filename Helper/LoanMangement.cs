using Ef_core_summery.Contexts;
using Ef_core_summery.Models;
using Ef_core_summery.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Ef_core_summery.Helper
{
    internal static class LoanMangement
    {
        public static bool BorrowBook(int bookId, int memberId, int borrowdays, LibararyDbContext dbContext)
        {
            using var transaction = dbContext.Database.BeginTransaction();
            try
            { var member = dbContext.Members.Find(memberId);
                if (member == null || member.status == MemberStatus.Suspended) 
                    return false; // Member not found
                
                var book = dbContext.Books.Find(bookId);
                if (book == null || book.AvailableCopies == 0) 
                    return false; // Book not available

                var loan = new Loan();
                dbContext.Loans.Add(loan);
                dbContext.SaveChanges(); // مهم جدًا

                var memberLoan = new MemberLoans
                {
                    BookID = bookId,
                    MemberID = memberId,
                    LoanID = loan.Id,
                    DueDate = DateTime.Now.AddDays(borrowdays)
                };
                dbContext.MemberLoans.Add(memberLoan);
                book.AvailableCopies -= 1;
                dbContext.SaveChanges();
                transaction.Commit();
                return true; // Successfully borrowed
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        
        public static bool ReturnBook(int memberId, int bookId, LibararyDbContext dbContext)
        {
            using var transaction = dbContext.Database.BeginTransaction();
            try
            {
                var memberLoan = dbContext.MemberLoans
                    .Include(ml => ml.Loan)
                    .Include(ml => ml.Book)
                    .FirstOrDefault(ml => ml.MemberID == memberId && ml.BookID == bookId && ml.ReturnDate == null);


                if (memberLoan is null)
                    return false; // No active loan found

                memberLoan.ReturnDate = DateTime.Now;
                memberLoan.Book.AvailableCopies += 1;
                if (memberLoan.ReturnDate > memberLoan.DueDate)
                {
                   var daysLate = (memberLoan.ReturnDate.Value - memberLoan.DueDate).Days;
                    decimal dailyFineRate = 1.00m; // Example fine rate per day
                    var fine = new Fine
                    {
                        Amount = dailyFineRate,
                        Loan= memberLoan.Loan
                    };

                    dbContext.Fines.Add(fine);
                    memberLoan.Loan.status = LoanStatus.Overdue;
                    var member = dbContext.Members.FirstOrDefault(x=> x.Id==memberLoan.MemberID);
                    if (member != null)
                    {
                        member.status = MemberStatus.Suspended;
                    }
                }
                dbContext.SaveChanges();
                return true; // Successfully returned
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
