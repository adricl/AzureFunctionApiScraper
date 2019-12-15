using System;
using Microsoft.Azure.Cosmos.Table;

using System.Linq;

namespace ApiToCloud
{
    public class Uploader
    {
        readonly CloudTable table;
        public Uploader(string tableName, string connectionString)
        {
            var storageAccount = CloudStorageAccount.Parse(connectionString);
            var tableClient = storageAccount.CreateCloudTableClient();
            table = tableClient.GetTableReference(tableName);
            table.CreateIfNotExistsAsync();
        }
    
        public void Upload(TableEntity message){
            var insert = TableOperation.InsertOrMerge(message);
            table.ExecuteAsync(insert);
        } 
    }
}