using System;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Ntt_Frmwrk_Cr
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new ConfigurationBuilder();
            //// установка пути к текущему каталогу
            //builder.SetBasePath(Directory.GetCurrentDirectory());
            //// получаем конфигурацию из файла appsettings.json
            //builder.AddJsonFile("appsettings.json");
            //// создаем конфигурацию
            //var config = builder.Build();
            //// получаем строку подключения
            //string connectionString = config.GetConnectionString("DefaultConnection");

            //var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            //var options = optionsBuilder
            //    .UseSqlServer(connectionString)
            //    .Options;

            using (AppContext db = new AppContext())
            {
                //при первом запуске добаляем два объекта
                //User user1 = new User { Name = "Rick", Age = 63 };
                //User user2 = new User { Name = "Morty", Age = 16 };
                //db.Users.AddRange(user1, user2);
                //db.SaveChanges();

                //db.GetService<ILoggerFactory>().AddProvider(new LoggerProvider());

                var users = db.Users.ToList();

                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }

                Console.ForegroundColor = color;
            }
            //Console.Read();
        }
    }
}
