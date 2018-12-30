using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fac
{
    class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("Fac of 5 is " + fac(5));
        }
        static long fac(int n) {
            if (n < 0) return -1;
            if (n == 0 || n == 1) return 1;
            else return fac(n - 1) * n;
        }
    }
}
