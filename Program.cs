namespace Module8
{
    /// <summary>
    /// Задание 8.1.4
    /// </summary>
    /// Придумайте простой класс, который будет предоставлять информацию об установленном в системе диске.
    /// Нужны свойства, чтобы хранить: имя диска , объём, свободное место. 
    /// Свойства инициализируются при создании нового объекта в методе-конструкторе.
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
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
