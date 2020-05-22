using System;
using System.IO;
using Microsoft.VisualBasic;

namespace Lab33
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter output = new StreamWriter("C:\\Users\\s\\RiderProjects\\Lab33\\output.txt");
            StreamReader input = new StreamReader("C:\\Users\\s\\RiderProjects\\Lab33\\input.txt");
            string str = input.ReadLine();
            Console.WriteLine(str);
            foreach (char i in str)
            {
                if (char.IsPunctuation(i) || char.IsNumber(i))
                {
                    str = str.Replace(i.ToString(), String.Empty);
                }
            }
            string[] words = str.Split(' ');
            Console.WriteLine("\nСлова з парною кiлькiстю лiтер:" );
            foreach (string word in words)
            {
                char[] charArr = word.ToCharArray();
                if (charArr.Length % 2 == 0)
                {
                    Console.WriteLine(Strings.LCase(word));
                    output.WriteLine(Strings.LCase(word));
                }
            }

            output.Close();
        }
    }
}
