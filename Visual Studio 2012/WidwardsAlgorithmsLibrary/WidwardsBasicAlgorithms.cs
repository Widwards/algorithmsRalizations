using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace WidwardsAlgorithmsLibrary
{
    /// <summary>
    /// Моя реализация алгоритмов
    /// <para>
    /// Правила:
    /// </para>
    /// 0. Мультипликативные константы можно опускать
    /// <para>
    /// 1. n^a растет быстрее, чем n^b, при a>b
    /// </para>
    /// 2. Любая экспонента растет быстрее любого полинома
    /// <para>
    /// 3. Любой полином растет быстрее любого полилогарифма
    /// </para>
    /// </summary>
    public class WidwardsBasicAlgorithms
    {
        /// <summary>
        /// Реализация алгоритма Фибоначчи
        /// <para>
        /// скорость O(n^2)
        /// </para>
        /// 0, 1, 1, 2, 3, 5, 8, 13...
        /// <para>
        /// экспоненциальная скорость роста
        /// </para>
        /// Fn=2^0.7n
        /// <para>
        /// Время работы работы T(n) >= T(n-1)+T(n-2)+3
        /// </para>
        /// </summary>
        /// <param name="n">Кол-во чисел фибоначчи</param>
        /// <returns>Ряд фибоначчи</returns>
        public static List<int> Fibonacchi(int n)
        {
            List<int> fib = new List<int>();
            if (n < 0)
            {
                throw new Exception("Error! n<0");
            }
            if (n == 0)
            {
                return fib;
            }
            fib.Add(0);
            if (n == 1)
            {
                return fib;
            }
            fib.Add(1);
            for (int i = 1; i < n - 1; i++)
            {
                fib.Add(fib[i] + fib[i - 1]);
            }
            
            
            return fib;
        }
        /// <summary>
        /// Реализация алгоритма фибоначчи. Тип чисел ulong
        /// <para>
        /// O(n^2)
        /// </para>
        /// 0, 1, 1, 2, 3, 5, 8, 13...
        /// <para>
        /// экспоненциальная скорость роста
        /// </para>
        /// Fn=2^0.7n
        /// <para>
        /// Время работы работы T(n) >= T(n-1)+T(n-2)+3
        /// </para>
        /// </summary>
        /// <param name="n">Кол-во чисел фибоначчи</param>
        /// <returns>Ряд фибонначи (ulong)</returns>
        public static List<ulong> FibocacciLong(int n)
        {
            List<ulong> fib = new List<ulong>();
            if (n < 0)
            {
                throw new Exception("Error! n<0");
            }
            if (n == 0)
            {
                return fib;
            }
            fib.Add(0);
            if (n == 1)
            {
                return fib;
            }
            fib.Add(1);
            for (int i = 1; i < n - 1; i++)
            {
                fib.Add(fib[i] + fib[i - 1]);
            }
            return fib;
        }

        /// <summary>
        /// Быстрая сортировка
        /// <para>
        /// скорость O(n log n) (в некоторых случаях O(n^2))
        /// </para>
        /// </summary>
        /// <param name="arr">Массив для сортировки</param>
        /// <returns>Отсортированный массив</returns>

        /// <summary>
        /// Быстрая сортировка
        /// <para>
        /// скорость O(n log n) (в некоторых случаях O(n^2))
        /// </para>
        /// </summary>
        /// <param name="arr">Массив для сортировки</param>
        /// <param name="min">Минимальный элемент для сортировки</param>
        /// <param name="max">Максимальный элемент для сортировки</param>
        public static void QuickSort(int[] arr, int min, int max)
        {
            int op = arr[(max - min) / 2 + min]; //Опорный элемент

            int i = min;
            int j = max;
            
            int tmp;
            while (i <= j)
            {
                while (arr[i] < op && i <= max) ++i;
                while (arr[j] > op && j >= min) --j;
                if (i <= j)
                {
                    tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    i++;
                    j++;
                }
            }
            if (j > min) QuickSort(arr, min, j);
            if (i < max) QuickSort(arr, i, max);
        }
    }
}
