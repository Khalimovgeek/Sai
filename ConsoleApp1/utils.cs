using System;
using System.Collections.Generic;
using Microsoft.Azure.CognitiveServices.Search;
using Microsoft.Azure.CognitiveServices.Search.WebSearch.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.Azure.CognitiveServices.Search.WebSearch;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    internal class utils
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public utils(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public static async Task qs(string query)
        {
            string apiKey = "d629e54b80c39210fb756701dd9e50eeef37e214be1569cb8d280b12c1c42d27";
            string apiUrl = $"https://serpapi.com/search?q={query}&api_key={apiKey}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage responseMessage = await client.GetAsync(apiUrl);
                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var result = await responseMessage.Content.ReadAsStringAsync();
                        dynamic res = JsonConvert.DeserializeObject<dynamic>(result);
                        foreach (var item in res["organic_results"])
                        {
                            string title = item["title"];
                            string url = item["url"];
                            string snippet = item["snippet"];

                            Console.WriteLine($"Title: {title}");
                            Console.WriteLine($"URL: {url}");
                            Console.WriteLine($"Snippet: {snippet}");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine($"API request failed with status code: {responseMessage.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
