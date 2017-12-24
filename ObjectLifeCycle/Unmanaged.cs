using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifeCycle
{
    class UnmangedWrapper : IDisposable
    {
        public FileStream Stream { get; private set; }
        public UnmangedWrapper()
        {
            this.Stream = File.Open("temp.dat", FileMode.Create);
        }
        ~UnmangedWrapper()
        {
            Dispose(false);
        }
        public void Close()
        {
            Dispose();
        }
        public void Dispose()
        {
            Dispose(true);
            System.GC.SuppressFinalize(this);
        }
        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Stream != null)
                {
                    Stream.Close();
                }
            }
        }
    }
}
