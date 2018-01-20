using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console1701
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\Users\HP\Desktop\PP2\Lab1");
            System.IO.FileInfo[] fileNames = dirInfo.GetFiles("*.*");
        }
    }
}
