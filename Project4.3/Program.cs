using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Задачи на использование операторов цикла с предусловием (пока условие истинно, выполянять действие). Осуществить ввод необходимых данных, выполнить реализацию алгоритма 
            с использованием операторов цикла while, обеспечить вывод полученных результатов. Использование других операторов цикла недопустимо.

            Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C 
            (без наложений). Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
            */

            Console.WriteLine("Введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число C");
            int c = Convert.ToInt32(Console.ReadLine());
            int counta = 0;

            while (a >= c) 
            {
                counta = a - c;
                counta++;
            }
        }
    }
}
