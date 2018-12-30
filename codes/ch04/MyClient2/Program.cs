using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args) {
            long result1 = AddClass.Add(2,3);
            long result2=MultiClass.Multi(2,3);
            Console.WriteLine($"result1={result1},result2={ result2}");
        }
    }
}
