using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args) {
            String s = "Hello,World!";
            String sub = s.Substring(1);
            
            Console.WriteLine($"s={s},sub={sub}");
            Console.WriteLine($"IndexOf:{s.IndexOf("ll")}");
           ;
        }
    }
}
