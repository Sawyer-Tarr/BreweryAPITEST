

using BreweryAPITEST;
using Newtonsoft.Json.Linq;





var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,
    RequestUri = new Uri("https://brianiswu-open-brewery-db-v1.p.rapidapi.com/breweries?by_state=Missouri"),
    Headers =
    {
        { "X-RapidAPI-Key", "95e6116b23mshd25623c7e1eef4ap1fdb4fjsn3841aa601faf" },
        { "X-RapidAPI-Host", "brianiswu-open-brewery-db-v1.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    var brewObject = JArray.Parse(body);
    Console.WriteLine(brewObject[0]["id"]);
}