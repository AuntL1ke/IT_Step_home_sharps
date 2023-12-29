using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOME
{
    internal class Website
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { name = value; }
            }

        }
        public string Url
        {
            get { return url; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { url = value; }
            }

        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { description = value; }
            }

        }
        public string Ip
        {
            get { return ip; }
            set
            {
                if (IsValidIpAddress(value))
                {
                    ip = value;
                }
            }
        }
        private static bool IsValidIpAddress(string value)
        {
            string[] parts = value.Split('.');
            if (parts.Length != 4)
            {
                return false;
            }

            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int num) || num < 0 || num > 255)
                {
                    return false;
                }
            }

            return true;
        }
        public void Print()
        {
            Console.WriteLine($"Website name - {Name}");
            Console.WriteLine($"Website path - {Url}");
            Console.WriteLine($"Website description - {Description}");
            Console.WriteLine($"Website ip-address - {Ip}");

        }
    }

    internal class Magazine
    {
        private string name;
        private int year;
        private string description;
        private string number;
        private string email;

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { name = value; }
            }

        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1800 && value <= 2025) { year = value; }
            }

        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { description = value; }
            }

        }
        public string Number
        {
            get { return number; }
            set
            {
                if (IsValidPhoneNumber(value))
                {
                    number = value;
                }
            }
        }

        private static bool IsValidPhoneNumber(string value)
        {
            if (value[0] == '+' && value.Length == 13)
            {
                return value.Substring(1).All(Char.IsDigit);
            }

            return false;
        }

        public string Email
        {
            get { return email; }
            set
            {
                if(value.Length>=6&&value.Length<=50&&value.Contains('@'))
                {
                    email = value;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"Magazine name - {Name}");
            Console.WriteLine($"Magazine year - {Year}");
            Console.WriteLine($"Magazine description - {Description}");
            Console.WriteLine($"Magazine contact number - {Number}");
            Console.WriteLine($"Magazine contact email - {Email}");

        }
    }
    internal class Store
    {
        private string name;
        private string address;
        private string description;
        private string number;
        private string email;

        public string Name
        {
            get { return name; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { name = value; }
            }

        }
        public string Address
        {
            get { return address; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { address = value; }
            }

        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { description = value; }
            }

        }
        public string Number
        {
            get { return number; }
            set
            {
                if (IsValidPhoneNumber(value))
                {
                    number = value;
                }
            }
        }

        private static bool IsValidPhoneNumber(string value)
        {
            if (value[0] == '+' && value.Length == 13)
            {
                return value.Substring(1).All(Char.IsDigit);
            }

            return false;
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Length >= 6 && value.Length <= 50 && value.Contains('@'))
                {
                    email = value;
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"Store name - {Name}");
            Console.WriteLine($"Store address - {Address}");
            Console.WriteLine($"Store description - {Description}");
            Console.WriteLine($"Store contact number - {Number}");
            Console.WriteLine($"Store contact email - {Email}");

        }
    }
    internal class home4
    {
        static void Main(string[] args)
        {
            Website website = new Website();
            website.Name = "Example Website";
            website.Url = "http://example.com";
            website.Description = "This is an example website.";
            website.Ip = "192.168.1.1";

            
            website.Print();
            Console.WriteLine(); 

            
            Magazine magazine = new Magazine();
            magazine.Name = "Example Magazine";
            magazine.Year = 2022;
            magazine.Description = "This is an example magazine.";
            magazine.Number = "+123456789012";
            magazine.Email = "example@example.com";

            
            magazine.Print();
            Console.WriteLine(); 

           
            Store store = new Store();
            store.Name = "Example Store";
            store.Address = "123 Main Street, City";
            store.Description = "This is an example store.";
            store.Number = "+987654321012";
            store.Email = "store@example.com";

           
            store.Print();
        }
    }
}
