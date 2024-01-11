using System;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Module8
{
    class Program
    {
        const string SettingsFileName = "Settings.cfg";

        static void Main()
        {
            WriteValues();

            ReadValues();
        }

        static void WriteValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
            {
                writer.Write(20.666F);
                writer.Write(@"Test line");
                writer.Write(55);
                writer.Write(false);
            }
        }

        static void ReadValues()
        {
            float FloatValue;
            string StringValue;
            int IntValue;
            bool BooleanValue;

            if (File.Exists(SettingsFileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    FloatValue = reader.ReadSingle();
                    StringValue = reader.ReadString();
                    IntValue = reader.ReadInt32();
                    BooleanValue = reader.ReadBoolean();
                }

                Console.WriteLine("Из файла считано");

                Console.WriteLine($"Дробь: {FloatValue}");
                Console.WriteLine($"Строка: {StringValue}");
                Console.WriteLine($"Целое число: {IntValue}");
                Console.WriteLine($"Булевое значение: {BooleanValue}");
            }
        }
    }
}
