using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Snai.ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) => {
                    builder.SetBasePath(context.HostingEnvironment.ContentRootPath)
                    .AddJsonFile("Ocelot.json");
                })
                .UseUrls("http://localhost:5000")
                .UseStartup<Startup>()
                .Build();
    }
}
