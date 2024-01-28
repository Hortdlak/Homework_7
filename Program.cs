using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Вывод натуральных чисел на заданом промежутке

            //Задайте значения M и N.Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
            //Использовать рекурсию, не использовать циклы.

            int M = Getting_number("M");

            int N = Getting_number("N");

            if (M > N)
            {
                (M, N) = (N, M);
            }

            ReadSegmentOfNumbers(M, N);

            #endregion

            #region  Вычисление функции Аккермана с помощью рекурсии

            //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


            #endregion

            #region  Вывод массива с помощью рекурсии

            //Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


            #endregion

            Console.ReadKey();
        }
        private static void ReadSegmentOfNumbers(int head, int tail)
        {

            if (head > tail)
            {
                return;
            }

            Console.Write(head);

            head++;

            if (head <= tail)
            {
                Console.Write(", ");
            }

            ReadSegmentOfNumbers(head, tail);

        }

        static int Getting_number(string pattern)
        {
            while (true)
            {
                Console.Write($"Введите число {pattern}: ");

                string UserInput = Console.ReadLine(); // запрос числа от пользователя

                Console.Clear();

                if (int.TryParse(UserInput, out int data)) // проверка числа
                {
                    return data; // выход числа из метода
                }
            }
        }
    }
}
