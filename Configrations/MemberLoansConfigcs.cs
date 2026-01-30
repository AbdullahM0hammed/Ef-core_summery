using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Configrations
{
    internal class MemberLoansConfigcs : IEntityTypeConfiguration<MemberLoans>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<MemberLoans> builder)
        {
            builder.HasKey(ml => new { ml.BookID, ml.LoanID, ml.MemberID });
        }
    }
}
