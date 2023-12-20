using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME
{
    internal class Program
    {
        static string GetSeason(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Winter";
                case 3:
                case 4:
                case 5:
                    return "Spring";
                case 6:
                case 7:
                case 8:
                    return "Summer";
                case 9:
                case 10:
                case 11:
                    return "Autumn";
                default:
                    return "Unknown season";
            }
        }   
        static void Main(string[] args)
        {

             Console.Write("Input number from 1 to 100 :: ");
             int num = int.Parse(Console.ReadLine());
             if (num >= 0 && num <= 100)
             {
                 if (num % 3 == 0 && num % 5 == 0)
                 {
                     Console.WriteLine($"Fizz Buzz - {num}");
                 }
                 else if (num % 3 == 0)
                 {
                     Console.WriteLine($"Fizz - {num}");
                 }
                 else if (num % 5 == 0)
                 {
                     Console.WriteLine($"Buzz - {num}");
                 }
                 else
                 {
                     Console.WriteLine(num);
                 }
             }
             else
             {
                 Console.WriteLine("Error! number is out of range");
             }

            
 
            Console.Write("input number :: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("input percent :: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine($"{p}% from {b} is {b * p / 100}");


            Console.WriteLine("Input 4 numbers");
            int n, m=0;
            ;
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{i + 1} number :: ");
                n = int.Parse(Console.ReadLine());
                m = m * 10 + n;
            }
            Console.WriteLine(m);


            Console.Write("Input six-digits number :: ");
            string s = Console.ReadLine();

            if (s.Length == 6 && Char.IsDigit(s[0]))
            {
                Console.Write("Input two indexes to replace number :: ");
                int a1 = int.Parse(Console.ReadLine());
                int a2 = int.Parse(Console.ReadLine());

                if (a1 >= 1 && a1 <= 6 && a2 >= 1 && a2 <= 6)
                {
                    
                    char[] charArray = s.ToCharArray();

                    char tmp = charArray[a1 - 1];
                    charArray[a1 - 1] = charArray[a2 - 1];
                    charArray[a2 - 1] = tmp;

                    
                    s = new string(charArray);

                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("Invalid indexes. Indexes should be between 1 and 6.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a six-digit number.");
            }

            Console.Write("Input date in format dd.MM.yyyy :: ");
            string inputDate = Console.ReadLine();

            if (DateTime.TryParseExact(inputDate, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                // Отримати день тижня
                string dayOfWeek = date.ToString("dddd");

                // Отримати сезон
                string season = GetSeason(date.Month);

                Console.WriteLine($"Date: {inputDate}");
                Console.WriteLine($"Day of week: {dayOfWeek}");
                Console.WriteLine($"Season {season}");
            }
            else
            {
                Console.WriteLine("Incorrect format of date.");
            }
        

            Console.Write("Input number 1 if you want to convert celsium to faranheight of 2 to converts faranheight to celsium :: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Input temperature :: ");
            int t = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"{t} in celsium is {9*t/5+32} in faranheight");
                    break;
                case 2:
                    Console.WriteLine($"{t} in faranheight is {(t - 32) * 5 / 9} in celsium");
                    break;
                default:
                    break;
            }


            Console.Write("Input 2 numbers :: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2  = int.Parse(Console.ReadLine());
            if (num1 < num2)
            {
                for (int i = num1;i<=num2;i++)
                {
                    if(i%2 == 0)

                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else if(num1 > num2)
            {
                for (int i = num2; i <= num1; i++)
                {
                    if (i % 2 == 0)

                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }    
    }
    
}
