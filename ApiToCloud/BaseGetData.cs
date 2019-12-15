using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace ApiToCloud
{
    public class BaseGetData
    {
        protected string connectionString;
        protected ILogger logger;
        protected HttpClient client;
        public BaseGetData(ILogger logger, HttpClient client, string connectionString){
            this.logger = logger;
            this.client = client;
            this.connectionString = connectionString;
        }

    }
}