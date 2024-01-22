using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotHouse house = new HotHouse()
            {
                Min = 10,
                Max = 20,
            };
            Heater heater = new Heater();
            Cooler cooler = new Cooler();

            Random random = new Random();
            while(true)
            {
                int weather = random.Next(-2, 3);
                house.Temperature += weather;
                
            }
        }
    }
}
