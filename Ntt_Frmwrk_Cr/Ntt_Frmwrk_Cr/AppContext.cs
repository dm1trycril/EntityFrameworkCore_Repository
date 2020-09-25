using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Logging;


namespace Ntt_Frmwrk_Cr
{
    class AppContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        private string connectionString { get; set; }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public AppContext()
        {

            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();

            connectionString = config.GetConnectionString("DefaultConnection");
            
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseLoggerFactory(loggerFactory);
        }
        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            //builder.AddProvider(new LoggerProvider());
        });
    }
}
