using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPhone
{
    class Program
    {
        static void Main(string[] args)
        {
            String pattern = @"^[ \.a-zA-Z]+\s(?<name>\w+),[a-zA-Z]+,x(?<ext>\d+)$";
            string[] sa = {
                "Dr.David Jones,Ophthalmology,x2441",
                "Mr.Cindy Harriman,Registry,x6231"
            };

            Regex rx = new Regex(pattern);
            foreach (String s in sa)
            {
                Match m = rx.Match(s);
                if (m.Success)
                {
                    Console.WriteLine("Name: {0},Phone: {1} ",m.Result("${name}"), m.Result("${ext}"));
                }
            }

            foreach (String s in sa)
            {
                string newStr =rx.Replace(s, "Name: ${name},Phone: ${ext}");
                Console.WriteLine(newStr);
            }

        }
    }
}
