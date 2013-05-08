using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidwardsAlgorithmsLibrary;

namespace MyAlgorithmRealization
{
    class AlgorithmUsing
    {
        //Правила:
        // 0. Мультипликативные константы можно опускать
        // 1. n^a растет быстрее, чем n^b, при a>b
        // 2. Любая экспонента растет быстрее любого полинома
        // 3. Любой полином растет быстрее любого полилогарифма



        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

        

        
        
        /// <summary>
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

        private static void FibUsing()
        {
            Console.WriteLine("fib(n)   enter n:");
            try
            {
                var fibonacci = WidwardsBasicAlgorithms.FibocacciLong(int.Parse(Console.ReadLine()));
                foreach (var f in fibonacci)
                {
                    Console.Write(f.ToString() + " ");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
        }

    }
}
