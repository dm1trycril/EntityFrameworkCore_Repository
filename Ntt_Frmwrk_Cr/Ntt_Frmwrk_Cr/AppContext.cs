using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Ntt_Frmwrk_Cr
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NttFramwrkCr_db;Trusted_Connection=True;");
            //optionsBuilder.UseLoggerFactory(loggerFactory);
        }
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddProvider(new LoggerProvider());
        });
    }
}
