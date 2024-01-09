using System;
using System.IO;
using System.Linq;

namespace Module8
{
    /// <summary>
    /// Задание 8.3.2
    /// </summary>
    /// Сделайте так, чтобы ваша программа из задания 8.3.1 
    /// при каждом запуске добавляла в свой исходный код комментарий 
    /// о времени последнего запуска. 

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\Skillfactory Modules\Module8\Module8\Program.cs";
            FileInfo fileInfo = new FileInfo(filePath);


            using (StreamWriter sw = fileInfo.AppendText()) 
            {
                sw.WriteLine($"///Последний запуск: {DateTime.Now}");
            }

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
///Последний запуск: 09.01.2024 17:10:40
///Последний запуск: 09.01.2024 17:10:44
///Последний запуск: 09.01.2024 17:10:51
