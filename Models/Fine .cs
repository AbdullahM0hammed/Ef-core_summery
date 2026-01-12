using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    internal class Fine: BaseEntity
    {
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

    }
}
