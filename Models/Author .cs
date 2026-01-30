using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    public class Author : BaseEntity
    {
        #region Properties

        //        Attributes:
        //●	Id – Unique identifier
        //●	FirstName
        //●	LastName
        //●	DateOfBirth
        public string? FirstName { get; set; } = null;
        public string? LastName { get; set; } = null;
        public DateTime DateOfBirth { get; set; }

        #endregion

        #region Relationship
        public virtual ICollection<Book> AuthoredBooks { get; set; } = new HashSet<Book>();
        #endregion
    }
}
