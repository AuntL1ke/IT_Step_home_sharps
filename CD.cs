using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class CD : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get => hasDisk; }

        public void Insert()
        {
            if (!HasDisk)
            {
                Console.WriteLine("Inserting CD...");
                hasDisk = true;
            }
            else
            {
                Console.WriteLine("CD is already inserted.");
            }
        }

        public void Reject()
        {
            if (HasDisk)
            {
                Console.WriteLine("Rejecting CD...");
                hasDisk = false;
            }
            else
            {
                Console.WriteLine("No CD to reject.");
            }
        }
        public override string GetName()
        {
            Console.Write("CD Name :: ");
            string name = Console.ReadLine();
            return name;
        }
        public override string ToString()
        {
            return $"CD: Name = {GetName()}";
        }   
       
    }
}
