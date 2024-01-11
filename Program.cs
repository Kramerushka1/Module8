using System;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Module8
{
    /// <summary>
    /// Задание 8.4.2
    /// </summary>
    /// Запишите  в файл из предыдущего задания информацию о доступе к нему с вашей машины. 
    /// Пример вывода, который должен получиться: 
    /// Файл изменен 02.11 14:53 на компьютере Windows 11

    class Program
    {
        const string filePath = "C:\\Users\\mrdoo\\Desktop\\BinaryFile.bin";

        static void Main()
        {
            WriteFile();
            ReadFile();
        }

        static void WriteFile()
        {
            string StringValue;

            if (File.Exists(filePath))
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Open)))
                {
                    writer.Write($"Файл изменен {DateTime.Now} на компьютере {Environment.OSVersion}");
                }
            }
        }

        static void ReadFile()
        {
            string StringValue;

            if (File.Exists(filePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    StringValue = reader.ReadString();
                }

                Console.WriteLine("Из файла считано");

                Console.WriteLine($"{StringValue}");
            }
        }
    }
}
