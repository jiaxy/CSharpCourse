using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int i = 101;
            do
            {
                result += i;
                i++;
            } while (i <= 100);
            System.Console.Write("result=" + result);

        }
    }
}
