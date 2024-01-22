using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Disk:IDisk
    {
        string memory;
        int memSize;

        string Memory { get; set; }
        int MemSize { get; set; }

        public Disk()
        {
            Memory = "Basic memory";
            MemSize = 16;
        }
        public Disk(string memory, int memSize)
        {
            Memory = memory;
            MemSize = memSize;
        }
        
        public virtual string GetName() { Console.Write("Name :: "); string name = Console.ReadLine(); return name; }
        public string Read()
        {
            Console.WriteLine("Reading from disk...");
            return Memory;
        }

        public void Write(string text)
        {
            Console.WriteLine("Writing to disk...");
            if (text.Length <= MemSize)
            {
                Memory = text; 
            }
            else
            {
                Console.WriteLine("Text exceeds disk memory size. Unable to write.");
            }
        }

        public override string ToString()
        {
            return $"Disk: Memory = {Memory}, Memory Size = {MemSize}";
        }
    }
}
