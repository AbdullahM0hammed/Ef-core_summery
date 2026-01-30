using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Ef_core_summery.Configrations
{
    internal class MemberConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            #region Properties
            /*
     Name	Varchar With Max Length 50
    Email	Varchar With Max Length 100 With Valid Format Of Email
    PhoneNumber	  Varchar With Max Length 11 With Valid Format Of Egyptian Phone Number
    Address	  Varchar With Max Length 100
    MembershipDate	Default Value Insertion Date
    Status	Store Label instead of Label value 
    */
            builder.Property(X => X.Name)
                    .HasColumnType("varchar")
                    .HasMaxLength(50);
            builder.Property(X => X.Email)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);
            builder.Property(X => X.PhoneNumber)
                   .HasColumnType("varchar")
                   .HasMaxLength(11);
            builder.Property(X => X.address)
                .HasColumnType("varchar")
                .HasMaxLength(100);
            builder.Property(X => X.MembershipDate)
                .HasDefaultValueSql("GETDATE()");
            builder.Property(X => X.status)
                .HasConversion<string>()
                .HasColumnType("varchar")
                .HasMaxLength(10);
            builder.ToTable(Tb =>
            {
                Tb.HasCheckConstraint("ValidEmailCheck", "Email Like '_%@_%._%' ");
                Tb.HasCheckConstraint(
                    "PhoneNumberCheck",
                    "PhoneNumber LIKE '01%' AND LEN(PhoneNumber) = 11 AND PhoneNumber NOT LIKE '%[^0-9]%'"
                );
            }); 
            #endregion
            //builder.Property(X => X.Id)
            //    .ValueGeneratedNever();
            builder.Property(x => x.Id)
       .ValueGeneratedOnAdd(); // بدل ValueGeneratedNever

        }
    }
}
