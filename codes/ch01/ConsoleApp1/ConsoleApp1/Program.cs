using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int n = 0;
            double d = 0;
            Console.Write("Please input an int: ");
            s = Console.ReadLine();
            n = Int32.Parse(s);
            Console.Write("Please input a double: ");
            s = Console.ReadLine();
            d = Double.Parse(s);
            Console.WriteLine("You have entered: " +(n+d));
            Console.WriteLine("You have entered: {0} and {1}", n, d);
            Console.WriteLine($"You have entered: {n} and {d}");
        }
    }
}
