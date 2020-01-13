using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace idk
{
    class Program
    {
        public static object RequestConstants { get; private set; }

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "https://dfapi.digitalfleet.com/api/v2/Truck"))
                {
                    request.Headers.TryAddWithoutValidation("Accept", "application/json");
                    request.Headers.TryAddWithoutValidation("X-API-KEY", "2437EA0D-C3D4-4879-9C92-6B6C52E9DF86");

                   
                    var response = await httpClient.SendAsync(request);

                    Console.WriteLine(response);
                   // Console.WriteLine(await response.Content.ReadAsStringAsync());
                    var x = new Apiresponse<truck>();
                    var y = JsonSerializer.Deserialize<Apiresponse<truck>>(await response.Content.ReadAsStringAsync());

                    string T = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, WriteIndented = true };
                    Apiresponse<truck> result = JsonSerializer.Deserialize<Apiresponse<truck>>(T, options);
                    string cool = JsonSerializer.Serialize(result, options);
                    Console.WriteLine(cool);

                }
            }
        }
    }
}
    

