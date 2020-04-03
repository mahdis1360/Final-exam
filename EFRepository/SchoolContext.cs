using Poco;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace EFRepository
{
    class SchoolContext : DbContext
    {
        public DbSet<StudentPoco> students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-41TMA4UR;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
