using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_text
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"S:\1temp\text.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                //Создаем массив строк для подсчета количества строк
                string[] arrayLineText = File.ReadAllLines(path);

                //Считываем текст в одну строку и выводим его для проверки
                string text = File.ReadAllText(path);
                Console.WriteLine(text);

                //Разбиваем строку на массив строк
                string[] arrayWordText = text.Split();
                Console.WriteLine("");
                Console.WriteLine("Количество строк в файле - " + arrayLineText.Length);
                Console.WriteLine("Количество слов в файле - " + arrayWordText.Length);
                Console.WriteLine("Количество символов в файле - " + text.Length);
            }
            Console.ReadKey();
        }
    }
}
