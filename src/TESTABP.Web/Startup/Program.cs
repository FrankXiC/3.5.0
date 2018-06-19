using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace TESTABP.Web.Startup {
    public class Program {
        public static void Main(string[] args) {
            BuildWebHost(args).Run();
            //var host = new WebHostBuilder()
            //    .UseKestrel()
            //    .UseContentRoot(Directory.GetCurrentDirectory())
            //    .UseIISIntegration()
            //    .UseStartup<Startup>()
            //    .Build();

            //host.Run();
        }
        public static IWebHost BuildWebHost(string[] args) {
            return WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostContext, config) => {
                    var env = hostContext.HostingEnvironment;
                    config.SetBasePath(Path.Combine(env.ContentRootPath))
                        .AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true);
                })
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();
        }
    }
}
