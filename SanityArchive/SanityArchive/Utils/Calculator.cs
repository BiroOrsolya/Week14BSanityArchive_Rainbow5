using System;
using System.Collections.Generic;
using System.IO;

namespace SanityArchive {
    namespace Utils
    {
        internal class Calculator
        {

            internal static long CalculateSizeOfFiles(string dirPath, IEnumerable<FileSystemInfo> paths)
            {
                long sumSize = 0;
                foreach (var path in paths)
                {
                    string pathName = dirPath + path.Name;
                    if (File.Exists(pathName))
                    {
                        sumSize += CalculateFileSize(pathName);
                    }
                    else if (Directory.Exists(pathName))
                    {
                        sumSize += CalculateDirectorySize(pathName);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a valid file or directory.", pathName);
                    }
                }
                return sumSize;

            }
            internal static long CalculateFileSize(string path)
            {
                FileInfo file = new FileInfo(path);
                return file.Length;

            }
            internal static long CalculateDirectorySize(string directory)
            {
                long sumSize = 0;
                string[] files = Directory.GetFiles(directory);
                foreach (string file in files)
                    sumSize += CalculateFileSize(file);

                string[] subdirectories = Directory.GetDirectories(directory);
                if (subdirectories != null)
                {
                    foreach (string subdirectory in subdirectories)
                        sumSize += CalculateDirectorySize(subdirectory);
                }
                return sumSize;
            }
        } 
    }
}