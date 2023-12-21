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
            string dirName = @"E:\Sample Folder\";  // Прописываем путь к директории
            if (Directory.Exists(dirName))  // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории каталога

                foreach (string d in dirs)  // Выведем их все

                {
                    Console.WriteLine(d);
                }

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);   // Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                {
                    Console.WriteLine(s);
                }
            }
            Console.WriteLine();
        }
        static void GetCatalogsCount()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"E:\Sample Folder\");
                if (dirInfo.Exists) //Проверяем наличие дирректории
                {
                    Console.WriteLine($"Количество файлов и папок {dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length}"); //Складываем количество файлов м папок
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

            dirInfo.CreateSubdirectory("NewFolder");
            Console.WriteLine("Папка 'NewFolder' создана");

            Console.WriteLine();
        }
        static void DeleteNewFolder()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"E:\Sample Folder\NewFolder");
                dirInfo.Delete(true);
                Console.WriteLine("Папка 'NewFolder' удалена");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
    }
}