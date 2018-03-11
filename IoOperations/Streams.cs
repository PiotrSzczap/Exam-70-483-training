﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoOperations
{
    class Streams
    {
        public void FileStreamExecute()
        {
            string path =@"c:\temp\test.dat";
            using (FileStream fileStream = File.Create(path))
            {
                string myValue ="MyValue";
                byte[] data = Encoding.UTF8.GetBytes(myValue);
                fileStream.Write(data, 0, data.Length);
            }
        }
    }
}
