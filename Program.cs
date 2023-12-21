namespace Module8
{
    /// <summary>
    /// Задание 8.1.5
    /// </summary>
    /// Сейчас пользователь видит, что у  вас на диске все файлы лежат в одной куче.
    /// Нужно создать папки(директории) для сортировки файлов.
    /// 
    /// Добавьте метод для создания новой директории на диске.
    /// Подумайте, какую коллекцию использовать для хранения созданных директорий.
    /// Пусть директория (папка) будет представлена классом
    /// 
    /// Реализация метода: 
    /// Принимает на вход имя папки, добавляет её в коллекцию папок, выводит информацию о том, что папка создана.




    /// 
    class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }

        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }
        
        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }

    }

    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
