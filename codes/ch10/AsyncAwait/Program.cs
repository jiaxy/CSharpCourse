using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Test();
            Console.WriteLine("waiting for result...");
            Console.ReadLine();
        }

        async void Test()
        {
            Task<double> task =
               Task.Run<double>(() => this.Calculate(10));
            double result=await task;
            Console.WriteLine("result is:" + result);
        }

        double Calculate(int n)
        {
            double s = 1;
            for(int i = 1; i < n; i++)
            {
                s = s * i;
            }
            return s;
        }
    }
}
