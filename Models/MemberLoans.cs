using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    public class MemberLoans
    {
        public DateTime DueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int MemberID { get; set; }
        public virtual Member Member { get; set; } = null!;
        public int LoanID { get; set; }
        public virtual Loan Loan { get; set; } = null!;
        public int BookID { get; set; }
        public virtual Book Book { get; set; } = null!;

    }
}
