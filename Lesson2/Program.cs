using System;

namespace Lesson2
{
    class Program
    {
        enum Months
        {
            Январь = 1,
            Февраль = 2,
            Март = 3, 
            Апрель = 4,
            Май = 5,
            Июнь = 6,
            Июль = 7, 
            Август = 8,
            Сентябрь = 9,
            Октярбрь = 10,
            Ноябрь = 11, 
            Декабрь = 12
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру за сутки");
            string MinimalT = Console.ReadLine();
            double MinT = Convert.ToDouble(MinimalT);
            Console.WriteLine("Введите максимальную температуру за сутки");
            string MaximalT = Console.ReadLine();
            double MaxT = Convert.ToDouble(MaximalT);
            double avarage = (MinT + MaxT) / 2;
            Console.WriteLine($"Средняя температура равна  {avarage} градусов");
            Console.WriteLine("Введите порядковый номер месяца");
            string Month = Console.ReadLine();
            int month = Convert.ToInt32(Month);
            var outMonth = (Months)month;
            Console.WriteLine("Текущий месяц - " + outMonth);
            if ( month % 2 ==0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четое");
            }
            if (((avarage > 0) && (month == 12) || (month == 1) || (month == 2)))
            {
                Console.WriteLine("Дождливая зима");
            }
            else
            {
                return;
            }                

        }
    }
}
