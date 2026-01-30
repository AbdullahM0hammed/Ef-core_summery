using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Ef_core_summery.Configrations
{
    internal class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            #region Properties
            builder.Property(X => X.FirstName)
           .HasColumnType("varchar")
           .HasMaxLength(20);
            builder.Property(X => X.LastName)
           .HasColumnType("varchar")
           .HasMaxLength(20);
           // builder.Property(x => x.Id)
           //.ValueGeneratedNever();
            builder.Property(x => x.Id)
       .ValueGeneratedOnAdd(); // بدل ValueGeneratedNever

            #endregion
        }
    }
}
