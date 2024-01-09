using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Square square = new Square(4);

            MixShape mixShape = new MixShape(triangle, square);
            Console.WriteLine(mixShape.GetArea());
            Console.WriteLine(mixShape.GetPerimeter());
        }

        
    }
}
