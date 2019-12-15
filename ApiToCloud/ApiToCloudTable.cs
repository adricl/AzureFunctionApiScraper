using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace ApiToCloud
{
    public static class ApiToCloudTable
    {
        [FunctionName("ApiToCloudTable")]
        public static void Run([TimerTrigger("0/58 * * * * *")]TimerInfo myTimer, ILogger log, ExecutionContext context)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            var process = new Processor(log, context.FunctionAppDirectory, false);
            process.Run();
        }
    }
}
