using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt
{
    class Program
    {
        delegate double NextValue(double x, double a);

        public static void Main(string[] args) {
            //Console.WriteLine(Newton(2.0, SqrtValue));
            Console.WriteLine(Newton(2.0,(x,a)=> x - (x * x - a) / (2 * x)));
            Console.WriteLine(Math.Sqrt(2.0));
        }

        // 求 x*x-a=0;   
        static double Newton(double a,NextValue next) {
            double x1 = 1.0;
            double x2 = next(x1, a);
            while (Math.Abs(x2 - x1) > 1e-6){
                x1 = x2;
                x2 = next(x1, a);
            }
            return x2;
        }

        private static double SqrtValue(double x, double a) {
            return x - (x * x - a) / (2 * x);
        }
    }
}
