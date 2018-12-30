using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    class Program
    {
        static void Main(string[] args) {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Ton V. Bergyk", "023-010-66756");
            dic["Tom Sony"] = "086-010-27654";
            dic["Mr. John"] = "071-222-33445";
            foreach (string key in dic.Keys)
            {
                Console.WriteLine(key + ":" + dic[key]);
            }
        }
    }
}
