using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8
{
    public static class DirectoryExtensions
    {
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;

            FileInfo[] files = d.GetFiles();
            foreach (FileInfo file in files)
            {
                size += file.Length;
            }

            DirectoryInfo[] dirs = d.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                size += DirSize(dir);
            }

            return size;
        }
    }
}
