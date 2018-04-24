using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeL3
{
    public static class Task2
    {
        public static void Numbers()
        {
            Console.WriteLine("2. Считывать с консоли числа, пока не будет введено число «-1». Среди введенных чисел " +
                "вывести все дублирующиеся.");
            int d = 0;
            int N = 100;
            int[] Mass = new int[N];
            int n = 0;

            while (d != -1)
            {
                Console.Write("Введите число: ");
                d = int.Parse(Console.ReadLine());
                Mass[n] = d;
                n++;
            }

            int[] Mass2 = new int[n];

            if (n != N)
            {
                for (int i = 0; i < Mass2.Length; i++)
                    Mass2[i] = Mass[i];
                Console.WriteLine(string.Join(" ", Mass2));
                GetTake(Mass2);
            }
            else
                GetTake(Mass);
        }


        public static void GetTake(int []Mass)
        {
            foreach (int val in Mass.Distinct())
            {
                int count = Mass.Count(x => x == val);
                if (count > 1)
                {
                    while (count > 0)
                    {
                        Console.Write(val + " ");
                        count--;
                    }
                    Console.WriteLine();
                }                
            }
        }
    }
}
