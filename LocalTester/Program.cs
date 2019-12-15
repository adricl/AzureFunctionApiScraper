using ApiToCloud;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace LocalTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new LoggerFactory();
            var appDir = Environment.CurrentDirectory;
            var process = new Processor(factory.CreateLogger("logs"), appDir, true);
            process.Run();
        }
    }
}
