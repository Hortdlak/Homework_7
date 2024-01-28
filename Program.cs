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

            //int M = Getting_number("M");

            //int N = Getting_number("N");

            //if (M > N)
            //{
            //    (M, N) = (N, M);
            //}

            //ReadSegmentOfNumbers(M, N);

            #endregion

            #region  Вычисление функции Аккермана с помощью рекурсии

            //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

            //int m = Getting_number("m");

            //int n = Getting_number("n");

            //int result = AckermannFunction(m, n);

            //Console.WriteLine($"A({m},{n}) = {result}");

            #endregion

            #region  Вывод произвольного массива с конца, c помощью рекурсии

            //Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

            int index = 0;

            Random rnd = new Random();

            int[] array = new int[rnd.Next(4, 12)];

            FillingArray(array, rnd, index);

            index = array.Length - 1;

            PrintArray(array, index);

            #endregion
        }

        static void PrintArray(int[] array, int index)
        {
            if (index < 0)
            {
                return;
            }

            Console.Write($"{array[index]} ");

            PrintArray(array, index - 1);
        }

        static void FillingArray(int[] array, Random rnd, int index)
        {
            if (index >= array.Length)
            {
                return;
            }

            array[index] = rnd.Next(1, 100);

            FillingArray(array, rnd, index + 1);
        }

        static int AckermannFunction(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return AckermannFunction(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
            }
            else
            {
                return 0;
            }
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
