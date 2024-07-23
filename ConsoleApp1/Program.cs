using Microsoft.Azure.CognitiveServices.Search.WebSearch;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                
                var x = Console.ReadLine();  // Replace with Console.ReadLine() for actual input
                var first = x.Split(' ')[0].ToLower();
                var cmd = x.Substring(first.Length).Trim();
                var cmd1 = cmd.Split(' ').First();
                var app = cmd.Split(' ').Last();
                if (first == "sai" && cmd1 != app)
                {
                    switch (cmd1)
                    {
                        case "install":
                            ins(app);
                            break;
                        case "search":
                            sr(app);
                            break;

                        default:
                            Console.WriteLine("Commands:\ninstall: install a package\ndetail: gives a description about an application");
                            break;
                    }
                }
                else if (first == "sai" && cmd1 == app)
                {
                    Console.WriteLine("Commands:\ninstall: install a package\nsearch: gives a description about an application");
                }
            }

        }
        public static async void ins(string app)
        {
            Console.WriteLine($"Searching {app}");
            await Task.Delay(1000);
            Console.WriteLine("Preparing Installation");
            Console.WriteLine($"{app} installed");
        }
        public static async void sr(string app) 
        {
            string price, size, Dldfrm, cat;
            price = size = Dldfrm = cat = "unknown";
            Console.WriteLine($"Searching {app}");
            utils.qs(app);
            await Task.Delay(1000);
            Console.WriteLine("hi");
            //Console.WriteLine($"General Details:\n Name:{a}\nPrice: {price}\n Size:{size} \nDownloading from:{Dldfrm} \nCategory:{cat}");

        }
     }
}
