using System;
using System.IO;
using System.Linq;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempFile = Path.GetTempFileName();
            var fileInfo = new FileInfo(tempFile);

            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Саша");
                sw.WriteLine("Паша");
                sw.WriteLine("Леша");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }

            try
            {
                string tempFile2 = Path.GetTempFileName();
                var fileInfo2 = new FileInfo(tempFile2);

                fileInfo2.Delete();

                fileInfo.CopyTo(tempFile2);
                Console.WriteLine($"файл {tempFile} скопирован в файл {tempFile2}");
                fileInfo.Delete();
                Console.WriteLine($"файл {tempFile} удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.ToString()}");
            }
        }
    }
}
