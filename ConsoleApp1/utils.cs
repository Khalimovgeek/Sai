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
        private readonly WebSearchClient _client;
        public WebSearchClient(string apikey) 
        {
            _client=new WebSearchClient(new ApiKeyServiceClientCredentials(apikey));
        }
        public async Task<WebWebAnswer> SearchAsync(string query)
        {
            var result=await _client.Web.SearchAsync(query);
            return result.WebPages;
        }
        public static async void link(string url,WebSearchClient client)
        {
            try
            {
                var webdata = await client.Web.SearchAsync(query: url);
                
            }
            catch (HttpRequestException nointernet)
            {
                Console.WriteLine("No internet"); 
            }

        }
        public static void search(string search)
        {
            var apikey = "";
            var client = new WebSearchClient(apikey);
            string url;
            url = Console.ReadLine();
            link(url, client);
        }
        public static string querry(string keyword)
        {
            string[] array = new string[] {"game","Paid","available on microsoft store"};
            for (int i = 0; i < array.Length; i++) 
            {
                var querry = $"Is {keyword} a {array[i]}";
                array[i] = search(querry) ;
                
            }
            string x = "";
            return x;
        }
    }
    
}
