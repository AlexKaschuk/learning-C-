using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskChapter1
{
    class HT1
    {
        static void Main(string[] args)
        {
            //1) прямокутник
            //Console.WriteLine("Enter sides of rectangle");
            //int A = Convert.ToInt32(Console.ReadLine());
            //int B = Convert.ToInt32(Console.ReadLine());
            //int C = Convert.ToInt32(Console.ReadLine());
            //if (C < A && C < B)
            //{
            //    int count = (A / C) * (B / C);
            //    double area = (B % C) * A + (A % C) * (B - B % C);
            //    Console.WriteLine("До прямокутника можу вмiститись {0} квадратiв зi стороною {1}, площа залишку = {2}", count, C, area);

            //}
            //else {
            //    Console.WriteLine("Сторони квардата бiльшi за сторон прямокутника, жоден квадрат не вмiщується у прямокутник");
            //}


            //2) банк

            //double deposite = 10000;
            //Console.WriteLine("Введіть процентну ставку за депозитом від 0 до 25%");

            //double percent = Convert.ToDouble(Console.ReadLine())/100;//тут ще можна було у циклі вводити ставку, якщо вона більша або менша від встановленої
            //int counter = 0;
            //do {
            //    deposite += deposite * percent;
            //    counter++;
            //} while (deposite < 11000);
            //Console.WriteLine("Ваш депозит перевищив 11000 за {0} місяців, на даний час сума складає {1}", counter, deposite);

            //3) цикл з числами

            //int A = 1, B = 9;
            //int z = A;
            //do
            //{
            //    for (int i = 0; i < z; i++) {
            //        Console.Write(z);
            //    }
            //    Console.Write("\n");
            //    z++;
            //} while (z != B+1);

            //4) читання числа у зворотньому порядку

            int N = 3451036;
            while (N > 10)
            {
                Console.Write(N % 10);
                N /= 10;
            }
            Console.Write(N);
            Console.Write("\n");
        }
    }
}
