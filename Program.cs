namespace Module8
{
    using System;
    using System.IO;

    namespace DriveManager
    {
        class Program
        {
            static void Main(string[] args)
            {
                // получим системные диски
                DriveInfo[] drives = DriveInfo.GetDrives();

                // Пробежимся по дискам и выведем их свойства
                foreach (DriveInfo drive in drives)
                {
                    Console.WriteLine($"Название: {drive.Name}");
                    Console.WriteLine($"Тип: {drive.DriveType}");
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Объем: {Math.Round (ConvertBytesToMegabytes (drive.TotalSize), 2)} Гб.");
                        Console.WriteLine($"Свободно: {Math.Round (ConvertBytesToMegabytes (drive.TotalFreeSpace), 2)} Гб.");
                        Console.WriteLine($"Метка: {drive.VolumeLabel}");
                        Console.WriteLine();
                    }
                }

                static double ConvertBytesToMegabytes(long bytes)
                {
                    return (float)bytes / (1024 * 1024 * 1024);
                }

            }
        }
    }
}