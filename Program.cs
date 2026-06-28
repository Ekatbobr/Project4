using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Задачи на использование операторов цикла for. Осуществить ввод необходимых данных, выполнить реализацию алгоритма с использованием операторов цикла for, обеспечить вывод полученных результатов. 
            Не разрешается использовать другие операторы цикла.

            Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1). 
            После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).
            5^2=1+3+5+7+9=25
            n2 += (2*i-1);   =   n2 = n2+(2*i-1);
            */

            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int n2 = 0;
            for (int i = 1; i <=n; i++)
            {
                n2 += (2*i-1);
                Console.WriteLine("Квадрат числа {0} равен {1}", i, n2);
            }
            Console.ReadKey();
        }
    }
}