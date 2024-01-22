using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Monitor:IPrintInformationcs
    {
        public virtual string GetName()
        {
            Console.Write("Monitor Name :: ");
            string name = Console.ReadLine();
            return name;
        }
        public void Print(string str)
        {
            Console.WriteLine($"Monitor shows {str}");
        }
    }
}
