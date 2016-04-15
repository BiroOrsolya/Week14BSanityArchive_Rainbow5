//using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace SanityArchive
{
    namespace Utils
    {
        internal class Compressor
        {
            internal static void CompressOne(FileSystemInfo src, FileInfo dest)
            {
                using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
                {
                    destArchiveObj.CreateEntryFromFile(src.FullName, src.Name);
                }
            }

            internal static void CompressMany(List<FileSystemInfo> src, FileInfo dest)
            {
                foreach (FileSystemInfo currentSourceFile in src)
                {
                    using (ZipArchive destArchiveObj = ZipFile.Open(dest.FullName, ZipArchiveMode.Update))
                    {
                        destArchiveObj.CreateEntryFromFile(currentSourceFile.FullName, currentSourceFile.Name);
                    }
                }
            }

            internal static void CompressDirectory(DirectoryInfo src, FileInfo dest)
            {
                ZipFile.CreateFromDirectory(src.FullName, dest.FullName);
            }

            internal static void DecompressOne(ZipArchiveEntry src, DirectoryInfo dest)
            {
                src.ExtractToFile(dest.FullName + Path.DirectorySeparatorChar + src.FullName);
            }

            internal static void DecompressMany(List<ZipArchiveEntry> src, DirectoryInfo dest)
            {
                foreach (ZipArchiveEntry currentSourceArchiveEntry in src)
                {
                    currentSourceArchiveEntry.ExtractToFile(dest.FullName + Path.DirectorySeparatorChar + currentSourceArchiveEntry.FullName);
                }
            }

            internal static void DecompressArchive(FileInfo src, DirectoryInfo dest)
            {
                ZipFile.ExtractToDirectory(src.FullName, dest.FullName);
            }
        }
    }
}
