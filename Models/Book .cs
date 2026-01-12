using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    internal class Book: BaseEntity
    {
        public string? Title { get; set; } = null;
        public decimal Price { get; set; }
        public DateTime PublishedDate { get; set; }
        public int 	AvailableCopies { get; set; }
        public int  TotalCopies { get; set; }
    }
}
