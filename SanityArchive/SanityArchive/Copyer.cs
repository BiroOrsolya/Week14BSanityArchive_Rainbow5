using System;
using System.Collections.Generic;
using System.IO;

namespace SanityArchive
{
    class Copyer
    {
        public static void CopyFiles(IEnumerable<FileSystemInfo> files, string sourceDir, string targetDir)
        {

            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }
            if (!Directory.Exists(sourceDir))
            {
                Console.WriteLine("Source path does not exist!");
            }
            else
            {
                List<string> path = new List<string>();
                foreach (var item in files)
                {
                    string it = sourceDir + Path.DirectorySeparatorChar + item.Name;
                    path.Add(it);
                }
                


                foreach (var file in path)
                {
                    
                    if (File.Exists(file))
                    {
                        CopyFile(file, sourceDir, targetDir);
                    }
                    else if (Directory.Exists(file))
                    {
                        CopyAllFilesFromDirectory(file, targetDir);

                    }
                    else
                    {
                        Console.WriteLine("{0} :is not an existing file", file.ToString());
                    }
                }

            }

        }
        static void CopyAllFilesFromDirectory(string sourceDir, string targetDir)
        {
            if (Directory.Exists(sourceDir))
            {
                string[] files = Directory.GetFiles(sourceDir);
                foreach (var file in files)
                {
                    CopyFile(file, sourceDir, targetDir);
                }
                string[] directories = Directory.GetDirectories(sourceDir);
                if (directories.Length > 0)
                {
                    foreach (var directory in directories)
                    {
                        CopyAllFilesFromDirectory(directory, targetDir);
                    }
                }
            }
            else
            {
                Console.WriteLine("It is not an existing directory");
            }
        }
        static void CopyFile(string file, string sourceDir, string targetDir)
        {
            string sourceFile = Path.Combine(sourceDir, file);
            string destFile = Path.Combine(targetDir, file);
            File.Copy(sourceFile, destFile, true);
        }
    }
}
