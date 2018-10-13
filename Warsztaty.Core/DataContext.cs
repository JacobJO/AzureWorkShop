using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Warsztaty.Core
{
     public class DataContext:DbContext
    {

        public virtual DbSet<ContactModel> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = tcp:jacobazure.database.windows.net, 1433; Initial Catalog = WarsztatAzureJacob; Persist Security Info = False; User ID=JacobJO ; Password=azureaccount123#; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }


    }
}
