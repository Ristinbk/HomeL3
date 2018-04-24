using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeL3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Номера заданий: 1, 2, 3, 0 - для выхода.");
            int selection;
            do
            {
                Console.Write("Для выполнения нужного действия введите, соответствующее ему, число: ");
                selection = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (selection)
                {
                    case 1:
                        Task1.Strings();
                        break;
                    case 2:
                        Task2.Numbers();
                        break;
                    case 3:
                        Task3.ClassPhone();
                        break;
                    case 0:
                        break;
                }
            } while (selection != 0);
        }
    }
}
