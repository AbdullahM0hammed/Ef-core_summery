using Ef_core_summery.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    internal class Loan: BaseEntity
    {
        /*
         Attributes:
●	Id – Unique identifier
●	LoanDate – Date when book was borrowed
●	Status (Borrowed, Returned, Overdue)
         */
        public DateTime LoanDate { get; set; }
        public LoanStatus status { get; set; }
    }
}
