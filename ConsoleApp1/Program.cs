using Microsoft.Azure.CognitiveServices.Search.WebSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static async void Main(string[] args)
        {
            var apikey = "";
            var client = new WebSearchClient(apikey);
            string url;
            url=Console.ReadLine();
            utils.link(url,client);
            
        }
    }
}
