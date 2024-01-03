using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp19
{
    class CreditCard
    {
        private string name;
        private string number;
        private string expirationDate;
        private string cvv;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }
                name = value;
            }
        }

        public string Number
        {
            get => number;
            set
            {
                if (value.Length == 16 && IsNumber(value))
                {
                    number = value;
                }
                else
                {
                    throw new ArgumentException("Invalid credit card number.");
                }
            }
        }

        public string ExpirationDate
        {
            get => expirationDate;
            set
            {
                if (IsExpirationDateValid(value))
                {
                    expirationDate = value;
                }
                else
                {
                    throw new ArgumentException("Invalid expiration date format or date has already passed.");
                }
            }
        }

        public string Cvv
        {
            get => cvv;
            set
            {
                if (IsCvvValid(value))
                {
                    cvv = value;
                }
                else
                {
                    throw new ArgumentException("Invalid CVV.");
                }
            }
        }

        private bool IsNumber(string number)
        {
            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsExpirationDateValid(string date)
        {
           /* if (date.Length != 5 || date[2] != '/')
            {
                return false;
            }
            string[] parts = date.Split('/');
            if (parts.Length != 2) { return false; }
            if (int.TryParse(parts[0], out int month) || month < 1 || month > 12)
            {
                return false;
            }*/
            return true;
        }

        private bool IsCvvValid(string cvv)
        {
            if (cvv.Length == 3 && IsNumber(cvv))
            {
                return true;
            }
            return false;
        }
        public void Input()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input card Name : ");
                    string n = Console.ReadLine();
                    Name = n;
                }
                catch (Exception ex){Console.WriteLine(ex.Message); Console.WriteLine("Try again"); }; }
            }
        }
        
    }

