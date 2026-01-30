using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_core_summery.Configrations
{
    internal class FineConfig : IEntityTypeConfiguration<Fine>
    {
        public void Configure(EntityTypeBuilder<Fine> builder)
        {
            /*
Amount	Stored as a decimal with 6 digits in total and 2 digits after the decimal point
IssuedDate	Default Value Insertion Date
Status	Store Label instead of Label value 
             */
            #region Properties
            builder.Property(f => f.Amount)
        .HasPrecision(6, 2);
            builder.Property(f => f.IssuedDate)
                .HasDefaultValueSql("GETDATE()");
            builder.Property(f => f.Status)
                .HasConversion<string>();
            #endregion

            #region Relationships
            builder.HasOne(X=>X.Loan) 
                .WithOne (L=>L.Fine)
                .HasForeignKey<Fine>(F=>F.LoanId);

            #endregion
        }
    }
}
