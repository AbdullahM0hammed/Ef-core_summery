using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    internal class Category: BaseEntity
    {
        /*
 Attributes:
●	Id – Unique identifier
●	Title - Name of the category
●	Description - Category details
 */
        public string? Title { get; set; } = null;
        public string? Description { get; set; } = null;
    }
}
