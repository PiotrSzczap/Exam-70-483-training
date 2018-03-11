using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoOperations
{
    class Files
    {
        public void Execute()
        {
            string path =@"c:\temp\test.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            fileInfo.MoveTo(path);
            fileInfo.CopyTo(path);
        }
    }
}
