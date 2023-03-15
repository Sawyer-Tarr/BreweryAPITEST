using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryAPITEST
{
    internal class Root
    {
    

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("state")]
            public string State { get; set; }

            [JsonProperty("website_url")]
            public string WebsiteURL { get; set; }

            [JsonProperty("brewery_type")]
            public string BreweryType { get; set; }

            [JsonProperty("hits")]
            public List<Hit> BreweryList { get; set; }


        
    }
    internal class Hit
    {
        [JsonProperty("body")]
        public List<Root> Data { get; set; }
    }

}
