using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Задачи на использование операторов цикла с постусловием. Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием операторов цикла do - while, 
            обеспечить вывод полученных результатов. Использование других операторов цикла недопустимо.

            Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
            Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
            */
            Console.WriteLine("Введите последовательность целых чисел. Окончанием последовательности служит число 0.");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            int c = 0;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    b = b + 1;
                }
                else if (a > 0) 
                {
                    c = c + 1;
                }

            }
            while (a != 0);
            if (b > c)
            {
                Console.WriteLine("Больше отрицательных");

            }
            else {
                Console.WriteLine("Больше положительных");
            
            }
            Console.ReadKey();
        }
    }
}
