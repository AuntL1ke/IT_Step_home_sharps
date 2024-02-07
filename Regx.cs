using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Program
    {
        static void Task1()
        {
            List<int> list = new List<int>();
            string pattern = @"^\d{4}$";
            var regx = new Regex(pattern);
            for(int i =0;i<=100000;i++)
            {
                Console.WriteLine(regx.IsMatch(i.ToString())
                    ? $"{i} match found {pattern}"
                    : $"{i} match NOT found {pattern}"); ;
                if (regx.IsMatch(i.ToString()))
                {
                    list.Add(i);
                }
                
            }
            Console.WriteLine("******************");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Task2()
        {
            string pattern = @"^[a-zA-Z]{3}\d{3}[a-zA-Z]{3}\d{3}$";
            var regx = new Regex(pattern);
            string[] words = { "lmn567opq890", "rst901uvw234", "bcd345efg678", "abc123def456", "xyz789ghi012", "qwe345rty678", "jkl901mno234", "pqr567stu890", "vwx123yza456", "hij789klm012" };
            foreach(var item in words)
            {
                Console.WriteLine(regx.IsMatch(item)
                    ? $"{item} is match {pattern}"
                    : $"{item} NOT match {pattern}");
            }
        }
        static void Task3()
        {
            string pattern = @"\b^[A-Z]{3}\b$";
            var regx = new Regex(pattern);
            string[] words = { "AAA", "DDDD", "123HHH6", "RBA", "HHH777JJJ" };
            foreach(var item in words)
            {
                Console.WriteLine(regx.IsMatch(item)
                    ? $"{item} is match {pattern}"
                    : $"{item} NOT match {pattern}");
            }
        }
        static void Task4()
        {
            string pattern = @"^(19\d{2}|20[0-8]\d|209[0-9])$";
;
            var regx = new Regex(pattern);
           
            string[] nums = { "1900", "2022", "1899", "2099", "2100", "20801"};
           


            foreach (var item in nums)
            {
                Console.WriteLine(regx.IsMatch(item)
                    ? $"{item} is match {pattern}"
                    : $"{item} NOT match {pattern}");
            }
        }
        static void Task5()
        {
            string pattern = @"\+38-0\d{2}-\d{6}23|\+38-0\d{2}-\d{4}00\d{2,}\d{1}";

            var regx = new Regex(pattern);
            string[] input = { "+38-099-123456", "+38-067-987654", "+38-050-876523", "+38-098-001223", "+38-044-002345", "+38-044-005560", "+38-066-000100" };

            foreach (var item in input)
            {
                Console.WriteLine(regx.IsMatch(item)
                    ? $"{item} is match {pattern}"
                    : $"{item} NOT match {pattern}");
            }
        }

        static void Main()
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5();
        }
    }
}