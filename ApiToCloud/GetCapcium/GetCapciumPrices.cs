using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiToCloud.GetCapcium
{
    public class GetCapciumPrices : BaseGetData
    {
        private readonly string tableName = "VegPrice";
        private readonly string PartitionKeyWoolies = "Woolies";
        private readonly string PartitionKeyColes = "Moles";
        private DateTime aest;
        private JsonSerializerSettings jsonSettings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            MissingMemberHandling = MissingMemberHandling.Ignore
        };

        public GetCapciumPrices(ILogger logger, HttpClient client, string connectionString, bool localTest) : base(logger, client, connectionString)
        {
            if (localTest)
                aest = DateTime.UtcNow.Add(TimeZoneInfo.FindSystemTimeZoneById("Australia/Victoria").BaseUtcOffset);
            else
                aest = DateTime.Now;
            
            logger.LogInformation(aest.ToString("O"));
        }

        public void Run()
        {
            var userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.79 Safari/537.36";
            client.DefaultRequestHeaders.Add("User-Agent", userAgent);

            var messageUploader = new Uploader(tableName, connectionString);


            //Woolies
            //Red Capsicum
            var type = "RedCapsicum";
            var url = "https://www.woolworths.com.au/apis/ui/product/detail/135306";
            var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            var capsicumDetails = JsonConvert.DeserializeObject<WooliesResult>(response, jsonSettings);
            Console.WriteLine($"Red Capcium Price per kilo: ${capsicumDetails.Product.CupPrice}");
            messageUploader.Upload(new VegPriceTable {
                PartitionKey = PartitionKeyWoolies,
                RowKey = type + "-" + aest.ToString("yyyy-MM-ddTHH"),
                Type = type,
                Price = capsicumDetails.Product.CupPrice
            });


            //Yellow Capsicum
            type = "YellowCapsicum";
            url = "https://www.woolworths.com.au/apis/ui/product/detail/135324";
            response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            capsicumDetails = JsonConvert.DeserializeObject<WooliesResult>(response, jsonSettings);
            Console.WriteLine($"Yellow Capcium Price per kilo: ${capsicumDetails.Product.CupPrice}");
            messageUploader.Upload(new VegPriceTable {
                PartitionKey = PartitionKeyWoolies,
                RowKey = type + "-" + aest.ToString("yyyy-MM-ddTHH"),
                Type = type,
                Price = capsicumDetails.Product.CupPrice
            });

            //Green Capsicum
            type = "GreenCapsicum";
            url = "https://www.woolworths.com.au/apis/ui/product/detail/135156";
            response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            capsicumDetails = JsonConvert.DeserializeObject<WooliesResult>(response, jsonSettings);
            Console.WriteLine($"Green Capcium Price per kilo: ${capsicumDetails.Product.CupPrice}");
            messageUploader.Upload(new VegPriceTable {
                PartitionKey = PartitionKeyWoolies,
                RowKey = type + "-" + aest.ToString("yyyy-MM-ddTHH"),
                Type = type,
                Price = capsicumDetails.Product.CupPrice
            });

            //Coles
            //Get Header from 
            // var url = "https://shop.coles.com.au/a/a-national/product/capsicum-red-loose";
            // var result = client.GetAsync(url).Result;
            // Console.WriteLine(result);
            // //var header

            // // //Red Capsicum
            // // url = "https://shop.coles.com.au/search/resources/store/20601/productview/bySeoUrlKeyword/capsicum-red-loose?catalogId=10576";
            // // var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // // var capsicumMolesDetails = JsonConvert.DeserializeObject<MolesResult>(response);
            // // Console.WriteLine($"Red Capcium Price per kilo: ${capsicumMolesDetails.CatalogEntryView[0].U2}");

            // // //Yellow Capsicum
            // // url = "https://shop.coles.com.au/search/resources/store/20601/productview/bySeoUrlKeyword/capsicum-yellow-loose?catalogId=10576";
            // // response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // // capsicumMolesDetails = JsonConvert.DeserializeObject<MolesResult>(response);
            // // Console.WriteLine($"Yellow Capcium Price per kilo: ${capsicumMolesDetails.CatalogEntryView[0].U2}");


            // // //Green Capsicum
            // // url = "https://shop.coles.com.au/search/resources/store/20601/productview/bySeoUrlKeyword/capsicum-green-loose?catalogId=10576";
            // // response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // // capsicumMolesDetails = JsonConvert.DeserializeObject<MolesResult>(response);
            // // Console.WriteLine($"Green Capcium Price per kilo: ${capsicumMolesDetails.CatalogEntryView[0].U2}");
        }
    }

}