using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ef_core_summery.Contexts
{
    internal class LibararyDbContext: DbContext
    {
        public LibararyDbContext(): base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer("Server = .; Database = Library_Management ; Trust_connection = true ; TrustServerCertificate=true");
        }
    }
}
