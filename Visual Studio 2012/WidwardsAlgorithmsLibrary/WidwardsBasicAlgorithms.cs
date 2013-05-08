using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WidwardsAlgorithmsLibrary
{
    public static class WidwardsBasicAlgorithms
    {


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
    }
}
