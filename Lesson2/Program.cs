using System;

namespace ConsoleApp1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цену Lay's ");
            string crisps = Console.ReadLine(); 
            double c = Convert.ToDouble(crisps);
            Console.WriteLine("Введите цену Хлеба");
            string bread = Console.ReadLine();
            double b = Convert.ToDouble(bread);
            Console.WriteLine("Введите цену Воды 5л");
            string water = Console.ReadLine();
            double w = Convert.ToDouble(water);
            Console.WriteLine("Введите сумму для оплаты");
            string price = Console.ReadLine();
            double M = Convert.ToDouble(price);
            Console.WriteLine("_________________________________________");
            Console.WriteLine("             ООО Розница К-1             ");
            Console.WriteLine("ПРИГЛАШАЕМ НА РАБОТУ: КАССИРОВ-ПРОДАВЦОВ,");
            Console.WriteLine("        ГРУЗЧИКОВ,УБОРЩИКОВ.             ");
            Console.WriteLine("  8-800-77-55-999    rabota@mariya-ra.ru ");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("                КУПИ 10 УПАКОВОК ВЛАЖНОГО КОРМА)              ");
            Console.WriteLine("                   ИЛИ 2 ПАЧКИ СУХОГО КОРМА                   ");
            Console.WriteLine("                     ДЛЯ ДОМАШНЕГО ПИТОМЦА                    ");
            Console.WriteLine("                     И ПОЛУЧИ ШАНС ВЫИГРАТЬ                   ");
            Console.WriteLine("                    КВАРТИРУ                                  ");
            Console.WriteLine("                        И ДРУГИЕ ПРИЗЫ                        ");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("НОМЕР ОПЕРАЦИИ 280 МАГАЗИН 916 КАССА 03                       ");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("______________________________________________________________");
            double p = 3.90;
            Console.WriteLine($"СУММА БЕЗ СКИДКИ:                          ={p + c + b + w}   ");
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("                    Кассовый чек                              ");
            double p1 = (double)(p * 1);
            Console.WriteLine($"1 ПАКЕТ СРЕДНИЙ БИО            { p * 1}        *1       = {p1}");
            Console.WriteLine("1 ЧИПСЫ LAY'S 4 СЫРА 125ГР");
            double c1 = c * 1;
            Console.WriteLine($"                              { c * 1}         *1             = {c1}");
            Console.WriteLine("1 ХЛЕБ БАБУШКИНА БУХАНКА 450ГР");
            double b1 = b * 1;
            Console.WriteLine($"                              { b * 1}          *1             = {b1}");
            Console.WriteLine("1 ВОДА СВЯТОЙ ИСТОЧНИК 5Л");
            double w1 = w * 1;
            Console.WriteLine($"                              { w * 1}          *1             = {w1}");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine($"ИТОГ                                         ={p + c + b + w} ");
            Console.WriteLine("_______________________________________________________________");
            double Nds = (p + c + b + w) * 0.2;
            int NDS = Convert.ToInt32(Nds);
            Console.WriteLine("СУММА НДС 20%                                                  =" + NDS); 
            double N = p + c + b + w;
            int Nn = Convert.ToInt32(N);
            Console.WriteLine("НАЛИЧНЫМИ                                                      =" + Nn);
            Console.WriteLine("ПОЛУЧЕНО НАЛИЧНЫМИ                                             =" + M); // Не получается прервать операцию, если сумму полученных денег, меньше необходимой суммы для оплаты
            double S = M - (p + c + b + w);//                                                             Подскажите в каком месте и что нужно было прописать. Пробовал через if else / 
            int Ss = Convert.ToInt32(S);//                                                                Указаывал что если M<Nn должно вывести окно что недостаточно средств для оплаты и ставил break; для заверешния
            Console.WriteLine("СДАЧА                                                          =" + Ss);// По итогу выводилось только окно что недостаточно  средств и операция считалась дальше, но СДАЧА уже была отрицательного значения
            Console.WriteLine("Кассир Иванов Иван Иванович");
            Console.WriteLine("\"OOO Розница К-1\""); 
            Console.WriteLine("630133. Новосибирск г.  Татьяны Снежиной ул. 25");
            Console.WriteLine("Место расчетов                           Магазин Мария--Ра №916");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("ЗН ККТ 00106304856502");
            Console.WriteLine("РН ККТ 0000273328038960");
            Console.WriteLine("ИНН 2225074005");
            Console.WriteLine("ФН 9280440300889366");
            Console.WriteLine("ФД 168396");
            Console.WriteLine("ФП 927496453");
            Console.WriteLine("ПРИХОД");
            Console.WriteLine("СНО ОСН");
            Console.Write(DateTime.Now);
        }
    }
}