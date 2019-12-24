using Microsoft.Azure.Cosmos.Table;

namespace ApiToCloud.GetCapcium
{
    public class VegPriceTable : TableEntity
    {
        public VegPriceTable()
        {
        }

        //Patition Key Store
        //Row Key 
        public double Price {get; set;}
        public string Type {get;set;}
    }

}