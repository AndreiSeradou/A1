using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using UnauthorizedDeliveriesTask3WebApi.table.CompletingTask;
using UnauthorizedDeliveriesTask3WebApi.table.TableEditor;

namespace UnauthorizedDeliveriesTask3WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        { 
           
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                        .UseUrls("http://localhost:4000");
                });
    }
}
