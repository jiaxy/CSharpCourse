using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPropagation
{
    class Program
    {
        static void Main(string[] args) {
           int n= Fun1(Console.ReadLine());
            Console.WriteLine(n);
        }

        static int Fun1(String str) {
            int num = Fun2(str.Trim());
            return num;
        }
        static int Fun2(String str) {
            return int.Parse(str);
        }
    }
}
