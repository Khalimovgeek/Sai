using System;
using System.Collections.Generic;
using Microsoft.Azure.CognitiveServices.Search;
using Microsoft.Azure.CognitiveServices.Search.WebSearch.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Azure.CognitiveServices.Search.WebSearch;

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

        public async Task<string> SearchAsync(string query)
        {
            string requestUri = $"https://serpapi.com/search?q={query}&apiKey={_apiKey}";
            HttpResponseMessage response = await _httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public static async Task<string> LinkAsync(string url, utils client)
        {
            try
            {
                var webData = await client.SearchAsync(url);
                return webData;
            }
            catch (HttpRequestException e)
            {
                return "No internet";
            }
        }

        public static async Task<string> SearchAsync1(string search)
        {
            var apiKey = "d629214be1569cb8d280b12c1c42d27"; // Replace with your actual API key
            var client = new utils(apiKey);

            string url = search;
            var result = await LinkAsync(url, client);
            return result;
        }

        public static async Task<string> QueryAsync(string keyword)
        {
            string[] array = new string[] { "game", "Paid", "available on Microsoft store" };
            string result = $"The {keyword} is a ";

            foreach (string item in array)
            {
                string query1 = $"Is {keyword} a {item}?";
                string searchResult = await SearchAsync1(Convert.ToString( query1));
            }

            return result;
        }

    }
}
