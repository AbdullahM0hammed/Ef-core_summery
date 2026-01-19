using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ef_core_summery.Configrations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            #region Properties
            builder.Property(X => X.Title)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);
            /*
             Price	
            Stored as a decimal with 6 digits in total 
            and 2 digits after the decimal point
            */
            builder.Property(X => X.Price)
                .HasPrecision(6, 2);
            //PublicationYear	From 1950 To Current Year
            builder.ToTable(Tb =>
            {
                Tb.HasCheckConstraint("PuplicationYearCheck", "PublishYear Between 1950 and YEAR(GETDATE())");
                Tb.HasCheckConstraint("AvailableCopiesCheck", "AvailableCopies <= TotalCopies");
            });
            #endregion
            #region Relationship
            builder.HasOne( X=>X.BookAuthor )
                .WithMany(X=>X.AuthoredBooks)
                .HasForeignKey(X=>X.AuthorID)
                .OnDelete(DeleteBehavior.Restrict); //No action on delete

            builder.HasOne(X => X.BookCategory)
                .WithMany(X => X.CategoryBooks)
                .HasForeignKey(X => X.CategoryID);

            #endregion
        }
    }
}
