using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntt_Frmwrk_Cr.v2
{
    class AppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=efbasicsappdb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //ИСКОЮЧЕНИЕ С ПОМОЩЬЮ FLUENT API:
            //С помощью этой строки игнорируется сущность Company, и таблица не вноситься в БД
            modelBuilder.Ignore<Company>();
            //С помощью этой строки игнорируется сущность Rate, и не вноситься в таблицу Product в БД 
            modelBuilder.Entity<Product>().Ignore(b => b.Rate);
            //modelBuilder.Entity<Country>();
        }
    }
}
