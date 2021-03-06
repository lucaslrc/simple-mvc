using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using simple_mvc.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace simple_mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new MvcContext())
            {
                if (db.Database.CanConnect())
                {
                    Console.WriteLine("Database is running...");
                }
                else
                {
                    Console.WriteLine("No database has found, please config your connection in file: /Data/MvcContext.cs\n" 
                                        + "or verify if you enter a command: dotnet ef database update.");
                
                    System.Environment.Exit(0);
                }
            }
            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
