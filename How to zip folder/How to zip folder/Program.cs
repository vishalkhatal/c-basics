using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace How_to_zip_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"D:\New folder";
            string zipPath = @"D:\PublishPackageFolder.zip";
            string extractPath = @"c:\result\extract";

            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
