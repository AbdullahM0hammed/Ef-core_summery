using Ef_core_summery.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    public class Fine: BaseEntity
    {
        #region Properties

        /*
         Attributes:
●	Id – Unique identifier
●	Amount – the fine amount
●	IssuedDate – Date when fine was issued
●	PaidDate – Date when fine was paid
●	Status ( Pending, Paid)
         */
        public decimal Amount { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public FineStatus Status { get; set; }
        #endregion

        #region Relationships
       public int LoanId { get; set; }
        public virtual Loan Loan { get; set; } = null!;
        #endregion

    }
}
