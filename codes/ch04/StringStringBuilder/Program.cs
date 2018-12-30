using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringStringBuilder
{
    class Program
    {
        static void Main(string[] args) {
            string a = "A";
            string s = "";
            System.Text.StringBuilder sb
                = new System.Text.StringBuilder();
            DateTime t0 = DateTime.Now;
            for (int i = 0; i < 100000; i++)
                s = .Insert(0, ".");
            DateTime t1 = DateTime.Now;
            for (int i = 0; i < 100000; i++)
                sb = sb.Insert(0, ".");
            DateTime t2 = DateTime.Now;

            Console.WriteLine(t1 - t0);
            Console.WriteLine(t2 - t1);
        }

    }
}
