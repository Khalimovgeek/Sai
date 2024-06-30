using Microsoft.Azure.CognitiveServices.Search.WebSearch;
using System;
using System.Collections.Generic;
using System.Linq;
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
                string price, size, Dldfrm, cat;
                price=size=Dldfrm=cat= "unknown";
                var x = Console.ReadLine();  // Replace with Console.ReadLine() for actual input
                var first= x.Split(' ')[0].ToLower();
                var cmd = x.Substring(first.Length).Trim();
                var cmd1 =cmd.Split(' ').First();
                var app = cmd.Split(' ').Last();
                if (first == "sai" && cmd1 !=app)
                {
                    switch (cmd1) 
                    {
                        case "install":
                            Console.WriteLine("Loading");
                            break;
                        case "detail":
                            Console.WriteLine($"General Details:\n Name:{app}\nPrice: {price}\n Size:{size} \nDownloading from:{Dldfrm} \nCategory:{cat}");
                            break;

                        default:
                            Console.WriteLine("Commands:\ninstall: install a package\ndetail: gives a description about an application");
                            break;
                    }
                }
                else if (first =="sai" && cmd1 == app)
                {
                    Console.WriteLine("Commands:\ninstall: install a package\ndetail: gives a description about an application");
                }
            }
        }
    }
}
