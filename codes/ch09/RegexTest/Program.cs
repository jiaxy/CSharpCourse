using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Regex.IsMatch("ABC3", @"^[^0-9]+$"));


            string pattern = "[Bbw]il";
            string s = "My friend Bill will pay the bill";
            if (Regex.IsMatch(s, pattern))
            {
                Console.WriteLine($"{s} matches {pattern}");
            }

            Regex rx = new Regex(pattern);
            MatchCollection mc= rx.Matches(s);
            Console.WriteLine($"matches {mc.Count} times.");
            foreach (Match mt in mc)
            {
                Console.WriteLine($"matches {mt.Value} at {mt.Index}");
            }

            Match m = rx.Match(s);
            while (m.Success)
            {
                Console.WriteLine($"matches {m.Value} at {m.Index}");
                //m = rx.Match(s, m.Index + m.Length);
                m = m.NextMatch();
            }
        }
            

    }
}
