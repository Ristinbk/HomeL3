using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeL3
{
    public static class Task1
    {
        public static void Strings()
        {
            Console.WriteLine("1. Считать строку с консоли.Создать словарь, где ключом будет символ строки, а значением – количество данных символов в считанной строке.");
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            Dictionary<string, int> line = new Dictionary<string, int>();
            line.Add(s, s.Length);
            Console.WriteLine(line[s]);
        }
    }
}
