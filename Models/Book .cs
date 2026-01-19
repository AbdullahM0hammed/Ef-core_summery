using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Models
{
    public class Book: BaseEntity
    {
        #region Properties
        public string? Title { get; set; } = null;
        public decimal Price { get; set; }
        public int PublishYear { get; set; }
        public int AvailableCopies { get; set; }
        public int TotalCopies { get; set; }
        #endregion

        #region Book-Author Relationship
        public int AuthorID { get; set; }
        public virtual Author BookAuthor { get; set; } = null!;
        #endregion

        #region Book-cat Relationship

        public int CategoryID { get; set; }
        public virtual Category BookCategory { get; set; } = null!;

        #endregion

        #region b-m-l
        public virtual ICollection<MemberLoans> BookLoans { get; set; } = new HashSet<MemberLoans>();
        #endregion
    }
}
