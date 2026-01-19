using Ef_core_summery.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    public class Loan: BaseEntity
    {
        #region Properties
        /*
 Attributes:
●	Id – Unique identifier
●	LoanDate – Date when book was borrowed
●	Status (Borrowed, Returned, Overdue)
 */
        public DateTime LoanDate { get; set; }
        public LoanStatus status { get; set; }

        #endregion

        #region Relationships
        public virtual Fine? Fine { get; set; }
        #endregion

        #region Memberloans
        public virtual ICollection<MemberLoans> Loanbook { get; set; } = new HashSet<MemberLoans>();
        #endregion
    }
}
