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

        static void Main(string[] args)
        {
            var x = Console.ReadLine();  // Replace with Console.ReadLine() for actual input
            var first = x.Split(' ')[0].ToLower();
            var cmd = x.Substring(first.Length).Trim();

            if (first == "sai")
            {
                if (cmd == "install") { Console.WriteLine("Loading"); }
                else if (cmd == "detail")
                {
                    Console.WriteLine($"General Details:\n Price: /free or paid/\n Size: /size of app/ \nDownloading from: /url or the app for downloading/ \nCategory: /type of the app/");
                }
                else
                {
                    Console.WriteLine("Commands:\ninstall: install a package\ndetail: gives a description about an application");
                }
                

            }
        }
    }
}
