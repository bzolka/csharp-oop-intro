using System;
using System.Collections.Generic;
using System.Text;
using Lib;
using System.IO;
using System.Diagnostics;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string currDir = Directory.GetCurrentDirectory();
            Console.WriteLine();
            DirCopy dirCopy = new DirCopy(
                Path.Combine(currDir, @"..\..\..\..\Data\"),
                Path.Combine(currDir, @"..\..\..\..\Data\Target")
                );

            dirCopy.FileCopy += new DirCopy.FileCopyDelegate(dirCopy_FileCopy);
            dirCopy.FileCopy += Trace_FileCopy;
            
            dirCopy.Run();

            dirCopy.FileCopy -= new DirCopy.FileCopyDelegate(dirCopy_FileCopy);
            dirCopy.FileCopy -= Trace_FileCopy;

            Console.ReadKey();
        }

        static void dirCopy_FileCopy(int fileCount, int index, string fileName)
        {
            Console.WriteLine(string.Format("Copying file {0}/{1} - {2}",
                index, fileCount, fileName));
        }

        static void Trace_FileCopy(int fileCount, int index, string fileName)
        {
            Trace.WriteLine(string.Format("Copying file {0}/{1} - {2}",
                index, fileCount, fileName));
        }
    }
}
