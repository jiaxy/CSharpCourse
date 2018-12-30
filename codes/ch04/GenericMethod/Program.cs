using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs) {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        static void Main(string[] args) {
            int a = 10, b = 20;
            char c ='I', d ='V';
            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);
            Console.WriteLine($"a={a},b={b},c={c},d={d}");

        }
    }
}
