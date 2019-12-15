using System.Collections.Generic;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiToCloud.GetFlindersStPersons
{
    public class PopulateFlindersStreetPersons : BaseGetData
    {
        private readonly string tableName = "FlindersSt";

        public PopulateFlindersStreetPersons(ILogger logger, HttpClient client, string connectionString) : base(logger, client, connectionString)
        {
        }

        public void Run()
        {
            
            var messageUploader = new Uploader(tableName, connectionString);

            foreach(var item in GetPersonCount()){
                messageUploader.Upload(item);
            }
        }
        public List<Table> GetPersonCount(){
            var result = new List<Table>();
            var type = "PersonCount";
            var url = "https://data.melbourne.vic.gov.au/resource/d6mv-s43h.json?$where=sensor_id%20in%20(41,%2022,%205,%206)";
            var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            logger.LogInformation(response);

            var persons = JsonConvert.DeserializeObject<List<PersonResult>>(response);

            foreach(var person in persons){
                var table = new Table
                {
                    Direction1 = person.direction_1,
                    Direction2 = person.direction_2,
                    Direction3 = person.total_of_directions,
                    Id = type + person.sensor_id,
                    PartitionKey = type,
                    RowKey = person.date_time.ToString("yyyy-MM-ddTHH:mm")
                };
                result.Add(table);
            }
            return result;
        }
    }

}