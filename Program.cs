using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Delag
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}: ${Price}";
        }
    }
    class Calculator
    {
        private Func<double, double, double> func;
        public enum Operation
        {
            Plus,
            Minus,
            Mult,
            Div
        }
        public void SetOperation(Operation op)
        {
            if(op == Operation.Plus)
            {
                this.func = (a, b) => a + b;
            }
            else if(op==Operation.Minus)
            {
                this.func = (a, b) => a - b;

            }
            else if(op==Operation.Mult)
            {
                this.func = (a, b) => a * b;

            }else if(op==Operation.Div)
            {
                this.func = (a, b) => b != 0 ? a / b : throw new ArgumentException("cannot divide by zero");

            }
            else
            {
                throw new ArgumentException("Invalid operation");
            }
        }
        public double Calculate(double one, double two)
        {
            if (func == null)
            { throw new InvalidOperationException("Operation not set. Call SetOperation method first."); }
            else
            {
                return func(one, two);
            }

        }

    }
    class Program
    {
        static void DrawSquare(uint height, ConsoleColor color, char symbol)
        {

            Console.ForegroundColor = color;
            for(uint i=0;i<height;i++)
            {
                for(uint j=0;j<height;j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
        static void DrawTriangle(uint height, ConsoleColor color, char symbol)
        {
            Console.ForegroundColor = color;
            for(uint i=0;i<height;i++)
            {
                for(uint j=0;j<=i;j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }
        }

        static int CompareByPrice(Product p1, Product p2)
        {
            return p1.Price.CompareTo(p2.Price);
        }

        delegate void Delag(uint height, ConsoleColor color, char symbol);

        static void Sort<T>(T[] arr, Comparison<T> comp)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comp(arr[j], arr[j + 1]) > 0)
                    {
      
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            DrawSquare(5, ConsoleColor.Red, '*');
            Console.WriteLine();
            DrawTriangle(5, ConsoleColor.DarkCyan, '+');
            Console.WriteLine();

            Delag delag;

            delag = DrawSquare;
            delag(5, ConsoleColor.Green, '$');
            Console.WriteLine();

            delag = DrawTriangle;
            delag(5, ConsoleColor.Magenta, '&');
            Console.WriteLine();

            Delag multidelag;

            multidelag = DrawSquare;

            multidelag += DrawTriangle;

            multidelag(5, ConsoleColor.DarkYellow, '!');

            Calculator calculator = new Calculator();


            calculator.SetOperation(Calculator.Operation.Plus);
            double result = calculator.Calculate(5, 3);
            Console.WriteLine("Result: " + result);

            calculator.SetOperation(Calculator.Operation.Minus);
            result = calculator.Calculate(5, 3);
            Console.WriteLine("Result: " + result);


            calculator.SetOperation(Calculator.Operation.Mult);
            result = calculator.Calculate(5, 3);
            Console.WriteLine("Result: " + result);


            calculator.SetOperation(Calculator.Operation.Div);
            result = calculator.Calculate(5, 3);
            Console.WriteLine("Result: " + result);

            string[] strings = { "apple", "banana", "kiwi", "orange", "grape" };

            Console.WriteLine("Before sorting:");
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }

       
            Sort(strings, (s1, s2) => s1.Length.CompareTo(s2.Length));

            Console.WriteLine("\nAfter sorting by length:");
            foreach (var str in strings)
            {
                Console.Write(str + " ");
            }

      
            Product[] products = {
            new Product("Laptop", 1200),
            new Product("Phone", 800),
            new Product("Tablet", 500),
            new Product("TV", 1500),
            new Product("Camera", 700)
        };

            Console.WriteLine("\n\nBefore sorting:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

            Sort(products, CompareByPrice);

            Console.WriteLine("\nAfter sorting by price:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }

        }
    }


}

