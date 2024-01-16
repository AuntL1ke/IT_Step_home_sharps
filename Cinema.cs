using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{

    class Director:ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object Clone()
        {
            Director dr = new Director();
            return dr;
        }

        public override string ToString()
        {
            return $"First Name :: {FirstName,-15} Last Name :: {LastName,-15}";
        }
    }

    class Movie:IComparable
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }

        public Director Direct {  get; set; }
       // public enum Genre { get;set; }
        public int Year { get; set; }
        public double Rank { get; set; }

        public int CompareTo(object obj)
        {
            if(obj is Movie)
            {
                return Name.CompareTo(((Movie)obj).Name);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"Name :: {Name, -10} Description :: {Description, -10} Country :: {Country, -10} Director :: {Direct} Year :: {Year, -10} Rating :: {Rank, -10}";
        }

    }

    

}
