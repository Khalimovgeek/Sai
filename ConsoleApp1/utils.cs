using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class utils
    {
        public static void link(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (System.ComponentModel.Win32Exception nointernet)
            {
                if (nointernet.ErrorCode == 404)
                {
                    Console.WriteLine("No internet");
                }
            }

        }
    }
    
}
