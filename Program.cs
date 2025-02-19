using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechMarket.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace TechMarket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            //var host = CreateHostBuilder(args).Build();
            /*using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try 
                {
                    var context = services.GetRequiredService<DataContext>();
                    context.Database.Migrate();
                    //add products and dummy customers to database
                    SeedData.SeedCustomers(context);
                }
                catch (Exception e)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "Error occured during migration");
                }
            }
            host.Run();*/
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
