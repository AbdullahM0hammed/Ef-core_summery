
using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ef_core_summery.Configrations
{
    internal class LoanConfig : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            /*
LoanDate	Default Value Insertion Date
Status	Store Label instead of Label value 
             */
            builder.Property(l => l.LoanDate)
                   .HasDefaultValueSql("GETDATE()");

            builder.Property(l => l.status)
                     .HasConversion<string>()
                     .HasColumnType("varchar")
                     .HasMaxLength(10);

        }
    }
}
