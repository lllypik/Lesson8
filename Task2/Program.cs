using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"S:\1temp\RandomNumbers.txt";
            Random randomNum = new Random();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i=0; i<10; i++)
                {
                    sw.WriteLine(randomNum.Next(-100, 100));
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                  sum += Convert.ToInt32(sr.ReadLine ());
                }
            }
            Console.WriteLine("Сумма чисел в файле по пути {0} составляет {1}", path, sum);
            Console.ReadLine();
        }
    }
}
