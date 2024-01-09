namespace Module8
{
    /// <summary>
    /// Задание 8.2.3
    /// </summary>
    /// 
    ///Добавьте в задание 8.2.2 удаление вновь созданной директории и проверьте: 
    ///теперь ваша программа не должна оставлять после себя следов!

    class Count
    {
        public static void FilesAndFolders()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\\");
                if (dir.Exists)
                {
                    Console.WriteLine($"В дирректории {dir.GetDirectories().Length + dir.GetFiles().Length} файлов и папок");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Dir
    {
        public static void Create()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\\newDirectory");
                if (!dir.Exists)
                {
                    dir.Create();
                    Console.WriteLine("Папка newDirectory создана");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Delete()
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\\newDirectory");
                if (dir.Exists)
                {
                    dir.Delete();
                    Console.WriteLine("Папка newDirectory удалена");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Count.FilesAndFolders();
            Console.WriteLine();

            Dir.Create();
            Count.FilesAndFolders();
            Console.WriteLine();

            Dir.Delete();
            Count.FilesAndFolders();
            Console.WriteLine();
        }
    }
}
