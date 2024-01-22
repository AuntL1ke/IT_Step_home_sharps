using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Comp:Disk,IPrintInformationcs
    {
        int countDisk;
        int countPrintDevice;
        Disk[] disk;
        IPrintInformationcs[] printDevice;
        Comp(int d, int pd)
        {
            countDisk = d;
            countPrintDevice = pd;
            disk = new Disk[countDisk];
            printDevice = new IPrintInformationcs[countPrintDevice];


        }
        public void Print(string str)
        {
            foreach(var device in printDevice)
            {
                device.Print(str);
            }
        }

        public void AddDevice(int index,  IPrintInformationcs si) { 
            if(index>=0&&index<countPrintDevice)
            {
                printDevice[index] = si;
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        public void AddDisk(int index, Disk d) {
            if (index >= 0 && index < countDisk)
            {
                disk[index] = d;
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
        }
        public bool CheckDisk(string device) {
            foreach(var item in disk)
            {
                if(item!=null && item.GetName()==device)
                {
                    return true;
                }
                
            }
            return false;


        }
        
        public void InsertReject(string device, bool b) {
            if(b)
            {
                foreach(var item in disk)
                {
                    if(item!=null)
                    {
                            
                    }
                }
                
            }
            else
            {
                disk.In
            }
        }
        public bool PrintInfo(string text, string device)
        {
            foreach (var item in printDevice)
            {
                if (item != null && item.GetName() == device)
                {
                    item.Print(text);
                    return true;
                }
            }
            Console.WriteLine($"Print device {device} not found.");
            return false;
        }
        public string ReadInfo(string device)
        {
            foreach (var item in disk)
            {
                if (item != null && item.GetName() == device)
                {
                    // Assuming there's some information to read from the device
                    return $"Read information from {device}.";
                }
            }
            return $"Disk {device} not found.";
        }
    
        public void ShowDisk() {
            foreach(var item in disk)
            {
                if(item!=null)
                {
                    Console.WriteLine($"Disk: {item.GetName()}");
                }
            }
        }
        public void ShowPrintDevice()
        {
            foreach (var item in printDevice)
            {
                if (item != null)
                    Console.WriteLine($"Print Device: {item.GetName()}");
            }
        }
        public bool WriteInfo(string text, string showDevice) {
            foreach (var item in printDevice)
            {
                if (item != null && item.GetName() == showDevice)
                {
                    Console.WriteLine($"Writing information to {showDevice}: {text}");
                    return true;
                }
            }
            Console.WriteLine($"Print device {showDevice} not found.");
            return false;
        }
        public override string GetName()
        {
            return "Comp";
        }
    }
}
