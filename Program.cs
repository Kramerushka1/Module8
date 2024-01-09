using Microsoft.VisualBasic.FileIO;

namespace Module8
{
    /// <summary>
    /// Задание 8.2.4
    /// </summary>
    /// 
    ///Создайте на рабочем столе папку testFolder. 
    ///Напишите метод, с помощью которого можно будет переместить её в корзину.

    class Count
    {
        public static void FilesAndFolders(string dirCount)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@dirCount);
                if (dir.Exists)
                {
                    Console.WriteLine($"В дирректории {dir.GetDirectories().Length + dir.GetFiles().Length} файлов и папок");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при подсчете файлов и папок: {e.Message}");
            }
        }
    }
    class Dir
    {
        public static void Create(string dirCreate)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@dirCreate);
                if (!dir.Exists)
                {
                    dir.Create();
                    Console.WriteLine("Папка testFolder создана");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при создании папки: {e.Message}");
            }
        }
        public static void Delete(string dirDelete)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@dirDelete);
                if (dir.Exists)
                {
                    dir.Delete();
                    Console.WriteLine("Папка testFolder удалена");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка при удалении папки: {e.Message}");
            }
        }
        public static void DeleteDirectory(string dirDelete)
        {
            try
            {
                FileSystem.DeleteDirectory(
                    dirDelete, 
                    UIOption.AllDialogs, 
                    RecycleOption.SendToRecycleBin, 
                    UICancelOption.ThrowException);
                Console.WriteLine("Папка testFolder удалена в корзину.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении папки в корзину: {ex.Message}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string dirCount = "C:\\Users\\mrdoo\\desktop";
            string newDir = "C:\\Users\\mrdoo\\desktop\\testFolder";

            Count.FilesAndFolders(dirCount);
            Console.WriteLine();

            Dir.Create(newDir);
            Count.FilesAndFolders(dirCount);
            Console.WriteLine();

            Dir.Delete(newDir);
            Count.FilesAndFolders(dirCount);
            Console.WriteLine();

            Dir.Create(newDir);
            Count.FilesAndFolders(dirCount);
            Console.WriteLine();

            Dir.DeleteDirectory(newDir);
            Count.FilesAndFolders(dirCount);
            Console.WriteLine();
        }
    }
}
