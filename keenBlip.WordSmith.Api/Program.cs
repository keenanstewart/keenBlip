using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
// using nlog.Web

namespace keenBlip.WordSmith.Api
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

		public static IWebHost BuildWebHost(string[] args) =>
			  WebHost.CreateDefaultBuilder(args)
				  .ConfigureAppConfiguration()
				  .ConfigureLogging()
				  .UseStartup<Startup>()
				  .Build();
    }
}
