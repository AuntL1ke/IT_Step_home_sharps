using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    interface IRemoveableDisk
    {
        bool HasDisk{get;}
        void Insert();
        void Reject();
    }
}
