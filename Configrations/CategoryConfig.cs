using Ef_core_summery.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Configrations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            #region Properties
            /*
Tittle 	Varchar With Max Length 50
Description	Varchar With Max Length 100
     */
            builder.Property(X => X.Title)
                .HasColumnType("varchar")
                .HasMaxLength(50);
            ;
            builder.Property(X => X.Description)
            .HasColumnType("varchar")
            .HasMaxLength(100);
            ; 
            #endregion
        }
    }
}
