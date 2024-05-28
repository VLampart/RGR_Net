using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    internal class Writer
    {
        public void Write(ReadWriteLock rwLock)
        {
            rwLock.WriteLock();
            Console.WriteLine("Writing...");
            rwLock.WriteUnlock();
        }
    }
}
