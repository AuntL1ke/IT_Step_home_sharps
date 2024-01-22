using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class HDD:Disk
    {
        public override string GetName()
        {
            Console.Write("HDD Name :: ");
            string name = Console.ReadLine();
            return name;
        }
        public override string ToString()
        {
            return $"HDD: Name = {GetName()}";
        }
    }
}
