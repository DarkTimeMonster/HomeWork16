using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            //Вывести и посчитать количество трехзначных чисел, сумма цифр которых равна 20.
            /*
            for (int x = 100; x < 1000; x++)
            {

            //int s = x / 100;
            //int d = (x / 10) % 10;
            //int e = x % 10;

            if (x/100 + (x/10)%10 + x%10 == 20)
            {
            Console.WriteLine($"Сумма этих чисел равняется 20 - {x}");
            count++;

            }

            }
            Console.WriteLine($"Количество чисел - {count}");
            */
            //За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу, в которую пользователь вводит сумму вклада и количество месяцев. А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.
            /*
            Console.WriteLine("Введите вклад - ");
            double sumv = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите кол во месяцев - ");
            int month = Convert.ToInt32(Console.ReadLine());

            double procent = 0.07;

            for (int x = 1; x <= month; x++)
            {

            double simp = sumv * procent;
            sumv = simp + sumv;
            }
            Console.WriteLine($"Сумма вашего вклада за {month} месяцев составит {sumv:f2} ");
            */

            //Рост стоимости акций. Выпустив акции предприятие, оценило их в 100 руб. за штуку в первоначальный момент. Каждый следующий месяц акции вырастали в цене на 10% от стоимости предыдущего месяца. Определить:

            double sum = 100;
            Console.WriteLine($"Начальная сумма - {sum} ");

            Console.Write($"Кол-во месяцев - ");
            int month = Convert.ToInt32(Console.ReadLine());

            double pricemonth7 = 0;
            double procent = 0.1;

            for (int x = 1; x <= month; x++)
            {
                double sumproce = sum * procent;
                sum = sum + sumproce;
                Console.WriteLine($"{x} месяц = {sum:f2} руб");

                if (x == 7)
                {

                    pricemonth7 = sum * 1000;
                }
            }
            Console.WriteLine($"Стоимость 1000 акций на 7 месяц = {pricemonth7}");
            Console.ReadKey();
        }
    }
}
