using System;
using System;
using System.IO;

namespace Module8
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs();
            GetCatalogsCount();
            
            CreateNewFolder();

            GetCatalogs();
            GetCatalogsCount();

            DeleteNewFolder();

            GetCatalogs();
            GetCatalogsCount();
        }

        static void GetCatalogs()
        {
            string dirName = @"E:\Sample Folder\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все

                {
                    Console.WriteLine(d);
                }

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
            }
        }
        static void GetCatalogsCount()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"E:\Sample Folder\");
                if (dirInfo.Exists)
                {
                    Console.WriteLine($"Количество файлов и папок {dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
        static void CreateNewFolder()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"E:\Sample Folder\");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            dirInfo.CreateSubdirectory("New Folder");
            Console.WriteLine("Папка 'New Folder' создана");
            Console.WriteLine();
        }
        static void DeleteNewFolder()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"E:\Sample Folder\New Folder");
                dirInfo.Delete(true);
                Console.WriteLine("Папка 'New Folder' удалена");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}