using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiToCloud.GetCapcium
{
    public partial class MolesResult
    {
        [JsonProperty("recordSetTotal")]
        public long RecordSetTotal { get; set; }

        [JsonProperty("m4")]
        public M4 M4 { get; set; }

        [JsonProperty("recordSetStartNumber")]
        public long RecordSetStartNumber { get; set; }

        [JsonProperty("recordSetCount")]
        public long RecordSetCount { get; set; }

        [JsonProperty("catalogEntryView")]
        public List<CatalogEntryView> CatalogEntryView { get; set; }
    }

    public partial class CatalogEntryView
    {
        [JsonProperty("a")]
        public Dictionary<string, List<string>> A { get; set; }

        [JsonProperty("p1")]
        public P1 P1 { get; set; }

        [JsonProperty("fi")]
        public string Fi { get; set; }

        [JsonProperty("coo")]
        public Coo Coo { get; set; }

        [JsonProperty("im")]
        public List<Im> Im { get; set; }

        [JsonProperty("s9")]
        public long S9 { get; set; }

        [JsonProperty("m3")]
        public List<M3> M3 { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("p")]
        public string P { get; set; }

        [JsonProperty("s")]
        public string S { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("u")]
        public long U { get; set; }

        [JsonProperty("pl")]
        public long Pl { get; set; }

        [JsonProperty("u2")]
        public string U2 { get; set; }
    }

    public partial class Coo
    {
        [JsonProperty("op")]
        public long Op { get; set; }

        [JsonProperty("oa")]
        public string Oa { get; set; }

        [JsonProperty("ob")]
        public string Ob { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("ot")]
        public string Ot { get; set; }

        [JsonProperty("og")]
        public string Og { get; set; }

        [JsonProperty("oi")]
        public long Oi { get; set; }
    }

    public partial class Im
    {
        [JsonProperty("th")]
        public Fl Th { get; set; }

        [JsonProperty("fl")]
        public Fl Fl { get; set; }
    }

    public partial class Fl
    {
        [JsonProperty("pa")]
        public string Pa { get; set; }
    }

    public partial class M3
    {
        [JsonProperty("a")]
        public A A { get; set; }

        [JsonProperty("p1")]
        public P1 P1 { get; set; }

        [JsonProperty("fi")]
        public string Fi { get; set; }

        [JsonProperty("s9")]
        public long S9 { get; set; }

        [JsonProperty("k")]
        public string K { get; set; }

        [JsonProperty("m")]
        public string M { get; set; }

        [JsonProperty("n")]
        public string N { get; set; }

        [JsonProperty("c1")]
        public string C1 { get; set; }

        [JsonProperty("a1")]
        public string A1 { get; set; }

        [JsonProperty("p")]
        public string P { get; set; }

        [JsonProperty("q")]
        public long Q { get; set; }

        [JsonProperty("s")]
        public string S { get; set; }

        [JsonProperty("t")]
        public string T { get; set; }

        [JsonProperty("u")]
        public long U { get; set; }

        [JsonProperty("pl")]
        public long Pl { get; set; }

        [JsonProperty("t1")]
        public string T1 { get; set; }

        [JsonProperty("u2")]
        public string U2 { get; set; }
    }

    public partial class A
    {
        [JsonProperty("A4")]
        public List<string> A4 { get; set; }

        [JsonProperty("O3")]
        public List<string> O3 { get; set; }

        [JsonProperty("D")]
        public List<string> D { get; set; }

        [JsonProperty("L2")]
        public List<bool> L2 { get; set; }

        [JsonProperty("P8")]
        public List<string> P8 { get; set; }

        [JsonProperty("W1")]
        public List<bool> W1 { get; set; }

        [JsonProperty("E1")]
        public List<bool> E1 { get; set; }

        [JsonProperty("T1")]
        public List<bool> T1 { get; set; }

        [JsonProperty("T2")]
        public List<string> T2 { get; set; }
    }

    public partial class P1
    {
        [JsonProperty("o")]
        public string O { get; set; }
    }

    public partial class M4
    {
        [JsonProperty("p1")]
        public long P1 { get; set; }
    }
}