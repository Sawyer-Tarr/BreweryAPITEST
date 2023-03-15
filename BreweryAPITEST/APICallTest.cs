using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreweryAPITEST
{
    public class APICallTest
    {
        public static async Task<Root> GetBrewery()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com/breweries"),
                Headers =
                    {
                        { "X-RapidAPI-Key", "95e6116b23mshd25623c7e1eef4ap1fdb4fjsn3841aa601faf" },
                        { "X-RapidAPI-Host", "brianiswu-open-brewery-db-v1.p.rapidapi.com" },
                    },
            };
            var body = "";
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                body = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(body);
            }
            return body;







            //var client = new HttpClient();
            //var request = new HttpRequestMessage
            //{
            //    Method = HttpMethod.Get,
            //    RequestUri = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com/breweries?by_state=Missouri"),
            //    Headers =
            //    {
            //        { "X-RapidAPI-Key", "95e6116b23mshd25623c7e1eef4ap1fdb4fjsn3841aa601faf" },
            //        { "X-RapidAPI-Host", "brianiswu-open-brewery-db-v1.p.rapidapi.com" },
            //    },
            //};


            ////var body = "";
            //var myClass = new Root();
            //Root breweries = new Root();
            //using (var response = await client.SendAsync(request))
            //{

            //    response.EnsureSuccessStatusCode();
            //    var body = await response.Content.ReadAsStringAsync();

            //    breweries = JsonConvert.DeserializeObject<Root>(body);

            //}
            //myClass = breweries;

            //return breweries;
        }



    }
}
