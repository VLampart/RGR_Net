using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    internal class Reader
    {
        public void Read(ReadWriteLock rwLock)
        {
            rwLock.ReadLock();
            Console.WriteLine("Reading...");
            rwLock.ReadUnlock();
        }
    }
}
