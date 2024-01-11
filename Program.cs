using System;
using System.IO;
using System.Linq;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives.Where(d => d.DriveType == DriveType.Fixed))
            {
                WriteDriveInfo(drive);
                DirectoryInfo root = drive.RootDirectory;
                DirectoryInfo[] folders = root.GetDirectories();

                WriteFoldereInfo(folders);
                Console.WriteLine();
            }
        }

        public static void WriteDriveInfo(DriveInfo drive)
        {
            Console.WriteLine($"Имя диска: {drive.Name}");
            Console.WriteLine($"Тип диска: {drive.DriveType}");

            if (drive.IsReady)
            {
                Console.WriteLine($"Объем диска: {drive.TotalSize}");
                Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                Console.WriteLine($"Метка тома: {drive.VolumeLabel}");
            }
        }
        public static void WriteFoldereInfo(DirectoryInfo[] folders)
        {
            Console.WriteLine("Папки: ");
            Console.WriteLine();

            foreach (DirectoryInfo folder in folders)
            {
                try
                {
                    Console.WriteLine($"{folder.Name} - {DirectoryExtensions.DirSize(folder)} байт");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{folder.Name} - Не удалось рассчитать размер {ex.Message}");
                }
            }
        }
    }
}
