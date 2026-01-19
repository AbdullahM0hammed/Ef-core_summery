using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    public class Category: BaseEntity
    {
        #region Properties
        /*
Attributes:
●	Id – Unique identifier
●	Title - Name of the category
●	Description - Category details
*/
        public string? Title { get; set; } = null;
        public string? Description { get; set; } = null;
        #endregion
        #region Relatioship
        public virtual ICollection<Book> CategoryBooks { get; set; } = new HashSet<Book>();
        #endregion
    }
}
