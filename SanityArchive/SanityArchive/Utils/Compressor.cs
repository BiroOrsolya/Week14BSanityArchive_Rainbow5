using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace SanityArchive
{
    namespace Utils
    {
        public class Compressor
        {
            public static void CompressOne(FileSystemInfo src, FileInfo dest)
            {
                using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
                {
                    destArchiveObj.CreateEntryFromFile(src.FullName, src.Name);
                }
            }

            public static void CompressMany(List<FileSystemInfo> src, FileInfo dest)
            {
                foreach (FileSystemInfo currentSourceFile in src)
                {
                    using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
                    {
                        destArchiveObj.CreateEntryFromFile(currentSourceFile.FullName, currentSourceFile.Name);
                    }
                }
            }

            public static void CompressDirectory(DirectoryInfo src, FileInfo dest)
            {
                ZipFile.CreateFromDirectory(src.FullName, dest.FullName);
            }

            public static void DecompressOne(ZipArchiveEntry src, DirectoryInfo dest)
            {
                src.ExtractToFile(dest.FullName + Path.DirectorySeparatorChar + src.FullName);
            }

            public static void DecompressMany(List<ZipArchiveEntry> src, DirectoryInfo dest)
            {
                foreach (ZipArchiveEntry currentSourceArchiveEntry in src)
                {
                    currentSourceArchiveEntry.ExtractToFile(dest.FullName + Path.DirectorySeparatorChar + currentSourceArchiveEntry.FullName);
                }
            }

            public static void DecompressArchive(FileInfo src, DirectoryInfo dest)
            {
                ZipFile.ExtractToDirectory(src.FullName, dest.FullName);
            }
        }
    }
}
