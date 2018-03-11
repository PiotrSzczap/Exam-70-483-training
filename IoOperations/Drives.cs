using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoOperations
{
    class Drives
    {
        public void Execute()
        {
            DriveInfo[] drivesInfo = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drivesInfo)
            {
                Console.WriteLine("Drive{ 0}", driveInfo.Name);
                Console.WriteLine("  Filetype:{ 0}", driveInfo.DriveType);
                if (driveInfo.IsReady == true)
                {
                    Console.WriteLine("  Volumelabel:{ 0}", driveInfo.VolumeLabel);
                    Console.WriteLine("  Filesystem:{ 0}", driveInfo.DriveFormat);
                    Console.WriteLine(
            "  Availablespacetocurrentuser:{ 0, 15} bytes",
            driveInfo.AvailableFreeSpace);
                    Console.WriteLine(
            "  Totalavailablespace:{ 0, 15} bytes",
            driveInfo.TotalFreeSpace);
                    Console.WriteLine(
            "  Totalsizeofdrive:{ 0, 15}  bytes",
            driveInfo.TotalSize);
                }
            }
        }
    }
}
