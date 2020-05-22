using System;

namespace Lab31
{
    public static class Program
    {
        static void Main()
        {
            int k = 0, k1 = 0, m = 0, m1 = 0, start = 0, end = 0;
            string str = Console.ReadLine();
            while (String.IsNullOrEmpty(str))
            {
                Console.WriteLine("Введiть рядок ще раз:");
                str = Console.ReadLine();
            }
            char[] charArr = str.ToCharArray();
            for (int i = 0; i < charArr.Length ; i++)
            {
                if (charArr[i] == '(')
                {
                    k++;
                    m++;
                }
                if (charArr[i] == ')')
                {
                    k--;
                    m++;
                }

                if (charArr[i] == '[')
                {
                    k1++;
                    m1++;
                }
                if (charArr[i] == ']')
                {
                    k1--;
                    m1++;
                }
            }

            if (m != 0)
            {
                if (k == 0) Console.WriteLine("Кiлькiсть круглих дужок спiвпадає.");
                if (k != 0) Console.WriteLine("Кiлькiсть круглих дужок не спiвпадає.");
            }
            else{ Console.WriteLine("Круглих дужок немає.");}

            if (m1 != 0)
            {
                if (k1 == 0) Console.WriteLine("Кiлькiсть квадратних дужок спiвпадає.");
                if (k1 != 0) Console.WriteLine("Кiлькiсть квадратних дужок не спiвпадає.");
            }
            else{ Console.WriteLine("Квадратних дужок немає.");}
            Console.WriteLine(charArr.Length);
            if (m!=0 & k == 0)
            {
                for (int i = 0; i < charArr.Length; i++)
                {
                    if (charArr[i] == '(') {start = i; break;}
                }
                for (int i = charArr.Length-1; i > 0; i--)
                {
                    if (charArr[i] == ')') {end = i; break;}
                }
            }
            string str1 = new string(charArr);
            Console.Write(str1.Remove(start, end - start + 1));


        }
    }
}
