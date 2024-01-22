using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class DVD : Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get => hasDisk; }

        public override string GetName()
        {
            Console.Write("DVD Name :: ");
            string name = Console.ReadLine();
            return name;
        }
        public void Insert()
        {
            if (!HasDisk)
            {
                Console.WriteLine("Inserting DVD...");
                hasDisk = true;
            }
            else
            {
                Console.WriteLine("DVD is already inserted.");
            }
        }

        public void Reject()
        {
            if (HasDisk)
            {
                Console.WriteLine("Rejecting DVD...");
                hasDisk = false;
            }
            else
            {
                Console.WriteLine("No DVD to reject.");
            }
        }
        public override string ToString()
        {
            return $"DVD: Name = {GetName()}";
        }
    }
}
