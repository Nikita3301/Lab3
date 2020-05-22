using System.IO;
using System;

namespace Lab32
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter g = new StreamWriter("C:\\Users\\s\\RiderProjects\\Lab32\\g.txt");
            StreamReader f = new StreamReader("C:\\Users\\s\\RiderProjects\\Lab32\\f.txt");
            string str;
            Console.WriteLine("Парнi числа з файлу:" );
            while ((str = f.ReadLine()) != null)
            {
                int number =Convert.ToInt32(str);
                if (number % 2 == 0)
                {
                    g.WriteLine(number);
                    Console.WriteLine(number);

                }
            }

            g.Close();
        }
    }
}
