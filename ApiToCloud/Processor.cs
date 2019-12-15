using System.Net.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Linq;
using ApiToCloud.GetFlindersStPersons;
using ApiToCloud.GetCapcium;

namespace ApiToCloud
{
    public class Processor
    {
        private static readonly HttpClient client = new HttpClient();
        private ILogger logger;
        private string appDir;
        private bool localTest;
        public Processor(ILogger log, string appDir, bool localTest)
        {
            this.logger = log;
            this.appDir = appDir;
            this.localTest = localTest;
        }

        public void Run()
        {
            var connectionString = "";
            var config = new ConfigurationBuilder()
                .SetBasePath(appDir)
                .AddEnvironmentVariables()
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .Build();

            // foreach(var item in config.AsEnumerable().ToList())
            // {
            //     logger.LogInformation($"Config Settings: {item.Key}");
            // }
            if (localTest)
                connectionString = config["values:AzureWebJobsStorage"];
            else 
                connectionString = config["AzureWebJobsStorage"];
            

            //var persons = new PopulateFlindersStreetPersons(logger, client, connectionString);
            //persons.Run();

            var capciumPrices = new GetCapciumPrices(logger, client, connectionString);
            capciumPrices.Run();
        }


    }
}
