using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteLock
{
    internal class ReadWriteLock
    {
        private readonly object _lock = new object();
        private int _readers = 0;
        private int _writers = 0;

        public void ReadLock()
        {
            lock (_lock)
            {
                while (_writers > 0)
                {
                    Monitor.Wait(_lock);
                }
                _readers++;
            }
        }

        public void ReadUnlock()
        {
            lock (_lock)
            {
                _readers--;
                if (_readers == 0)
                {
                    Monitor.PulseAll(_lock);
                }
            }
        }

        public void WriteLock()
        {
            lock (_lock)
            {
                while (_writers > 0 || _readers > 0)
                {
                    Monitor.Wait(_lock);
                }
                _writers++;
            }
        }

        public void WriteUnlock()
        {
            lock (_lock)
            {
                _writers--;
                Monitor.PulseAll(_lock);
            }
        }
    }
}
