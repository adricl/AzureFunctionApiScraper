using Microsoft.Azure.Cosmos.Table;

namespace ApiToCloud.GetCapcium
{
    public class CapciumTable : TableEntity
    {
        public CapciumTable()
        {
        }

        //Body of request
        public string Body {get;set;}

        //Direction 1 From
        public int Direction1 {get;set;}
        //Direction 1 To
        public int Direction2 {get;set;}
        public int Direction3 {get;set;}
        public string Id {get;set;}
        public string Type {get;set;}
    }

}