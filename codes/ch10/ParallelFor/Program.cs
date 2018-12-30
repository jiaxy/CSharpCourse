using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 10, i => {
                double result = Calc(i);
                Console.WriteLine($"Calc({i})={result}");

            });
            Console.ReadLine();
        }

        static double Calc(int n)
        {
            double f = 1;
            for (int i = 1; i <= n; i++) f *= i;
            return f;
        }
    }
}
