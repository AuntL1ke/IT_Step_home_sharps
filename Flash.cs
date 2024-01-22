using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Flash:Disk, IRemoveableDisk
    {
        bool hasDisk;
        public bool HasDisk { get => hasDisk; }

        public void Insert()
        {
            if (!HasDisk)
            {
                Console.WriteLine("Inserting Flash...");
                hasDisk = true;
            }
            else
            {
                Console.WriteLine("Flash is already inserted.");
            }
        }

        public void Reject()
        {
            if (HasDisk)
            {
                Console.WriteLine("Rejecting Flash...");
                hasDisk = false;
            }
            else
            {
                Console.WriteLine("No Flash to reject.");
            }
        }
        public override string GetName()
        {
            Console.Write("Flash Name :: ");
            string name = Console.ReadLine();
            return name;
        }
        public override string ToString()
        {
            return $"Flash: Name = {GetName()}";
        }
    }
}
