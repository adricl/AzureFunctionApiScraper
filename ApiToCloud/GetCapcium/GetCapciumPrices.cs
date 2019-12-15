using System;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace ApiToCloud.GetCapcium
{
    public class GetCapciumPrices : BaseGetData
    {
        private readonly string tableName = "capcium";

        public GetCapciumPrices(ILogger logger, HttpClient client, string connectionString) : base(logger, client, connectionString)
        {
        }

        public void Run()
        {
            var userAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.79 Safari/537.36";
            // client.DefaultRequestHeaders.Add("User-Agent", userAgent);

            // //var messageUploader = new Uploader(tableName, connectionString);
            // //Woolies
            // //Red Capsicum
            // var url = "https://www.woolworths.com.au/apis/ui/product/detail/135306";
            // var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // var capsicumDetails = JsonConvert.DeserializeObject<WooliesResult>(response);
            // Console.WriteLine($"Red Capcium Price per kilo: ${capsicumDetails.Product.InstoreCupPrice}");

            // //Yellow Capsicum
            // url = "https://www.woolworths.com.au/apis/ui/product/detail/135324";
            // response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // capsicumDetails = JsonConvert.DeserializeObject<WooliesResult>(response);
            // Console.WriteLine($"Yellow Capcium Price per kilo: ${capsicumDetails.Product.InstoreCupPrice}");

            // //Green Capsicum
            // url = "https://www.woolworths.com.au/apis/ui/product/detail/135156";
            // response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // capsicumDetails = JsonConvert.DeserializeObject<WooliesResult>(response);
            // Console.WriteLine($"Green Capcium Price per kilo: ${capsicumDetails.Product.InstoreCupPrice}");

            //Coles
            //Get Header from 
            var url = "https://shop.coles.com.au/a/a-national/product/capsicum-red-loose";
            var result = client.GetAsync(url).Result;
            Console.WriteLine(result);
            //var header

            // //Red Capsicum
            // url = "https://shop.coles.com.au/search/resources/store/20601/productview/bySeoUrlKeyword/capsicum-red-loose?catalogId=10576";
            // var response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // var capsicumMolesDetails = JsonConvert.DeserializeObject<MolesResult>(response);
            // Console.WriteLine($"Red Capcium Price per kilo: ${capsicumMolesDetails.CatalogEntryView[0].U2}");

            // //Yellow Capsicum
            // url = "https://shop.coles.com.au/search/resources/store/20601/productview/bySeoUrlKeyword/capsicum-yellow-loose?catalogId=10576";
            // response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // capsicumMolesDetails = JsonConvert.DeserializeObject<MolesResult>(response);
            // Console.WriteLine($"Yellow Capcium Price per kilo: ${capsicumMolesDetails.CatalogEntryView[0].U2}");


            // //Green Capsicum
            // url = "https://shop.coles.com.au/search/resources/store/20601/productview/bySeoUrlKeyword/capsicum-green-loose?catalogId=10576";
            // response = client.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
            // capsicumMolesDetails = JsonConvert.DeserializeObject<MolesResult>(response);
            // Console.WriteLine($"Green Capcium Price per kilo: ${capsicumMolesDetails.CatalogEntryView[0].U2}");
        }
    }

}