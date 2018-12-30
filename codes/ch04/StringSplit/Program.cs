using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args) {
            string path = @"d:\scExample\ch06\Test.cs";
            string[] words = path.Split(new Char[] { ':', '\\' });

            string drive = words[0];
            string file = words[words.Length - 1];

            Console.WriteLine(drive);
            Console.WriteLine(file);
        }
    }
}
