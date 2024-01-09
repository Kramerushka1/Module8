using System;
using System.IO;
using System.Linq;

namespace Module8
{
    /// <summary>
    /// Задание 8.3.1
    /// </summary>
    /// Напишите программу, которая выводит 
    /// свой собственный исходный код в консоль.

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Skillfactory Modules\Module8\Module8\Program.cs";
            
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
