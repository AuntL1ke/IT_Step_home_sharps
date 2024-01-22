using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Printer:IPrintInformationcs    
    {
        public virtual string GetName()
        {
            Console.Write("Printer Name :: ");
            string name = Console.ReadLine();
            return name;
        }
        public void Print(string str)
        {
            Console.WriteLine($"Printing {str}");
        }
    }
}
