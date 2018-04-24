using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeL3
{
    public static  class Task3
    {
        public static void ClassPhone()
        {
            Console.WriteLine("3.Создать класс «Телефон», который содержит следующие данные: код города, номер телефона, " +
             "которые не могут быть изменены. Добавить метод, который возвращает строку вида «(999) 999999» или «999999», " +
             "если код города отсутствует. Преобразовать класс «Телефон» на работу со свойствами.");

            Phone phone = new Phone(315, "123456");            
            Phone phone1 = new Phone(212, "345536");
            Phone phone2 = new Phone("863543");
            Console.WriteLine(GetString(phone.CodeCity, phone.NumberPhone));
            Console.WriteLine(GetString(phone1.CodeCity, phone1.NumberPhone));
            Console.WriteLine(GetString(phone2.CodeCity, phone2.NumberPhone));
        }

        public class Phone
        {
            public int CodeCity { get; private set; }
            public string NumberPhone { get; private set; }

            public Phone(int codeCity, string numberPhone)
            {
                CodeCity = codeCity;
                NumberPhone = numberPhone;
            }

            public Phone(string numberPhone) => NumberPhone = numberPhone;
        }

        public static string GetString(int CodeCity, string NumberPhone)
        {
            string str;
            if (CodeCity!=0)
                str = "(" + CodeCity + ") " + NumberPhone;
            else
                str = NumberPhone;
            return str;
        }
    }
}
