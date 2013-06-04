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

        static void Main(string[] args)
        {
            QuickSortUsing();
            Console.ReadKey();
        }

        

        private static void FibUsing()
        {
            Console.WriteLine("fib(n)   enter n:");
            try
            {
                var fibonacci = WidwardsBasicAlgorithms.Fibonacchi(int.Parse(Console.ReadLine()));
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

        private static void QuickSortUsing()
        {
            Console.WriteLine("Enter number of elements [10]:");
            int n=10;
            try
            {
                int tmp = int.Parse(Console.ReadLine());
                if (tmp != 0)
                {
                    n = tmp;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            int[] arr = new int[n];

            Random rd = new Random();

            for (int i = 0; i < arr.Length; i++)
			{
                arr[i] = rd.Next(99);
			}
                

            Console.WriteLine("Array before sorting:");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            
            WidwardsBasicAlgorithms.QuickSort(arr, 0, arr.Length-1);
            Console.WriteLine("\n\nArray after sorting:");
            foreach (int i in arr)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();
        }

    }
}
