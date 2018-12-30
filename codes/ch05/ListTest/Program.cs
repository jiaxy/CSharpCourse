using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args) {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Carrot");

            Console.WriteLine("Count:    {0}", fruits.Count);
            foreach (string fruit in fruits)
                Console.Write("\t" + fruit);
            Console.WriteLine();

            for (int i = 0; i < fruits.Count; i++)
                Console.Write("\t" + fruits[i]);
            Console.WriteLine();

            IEnumerator<string> myEnumerator = fruits.GetEnumerator();
            while (myEnumerator.MoveNext())
                Console.Write("\t{0}", myEnumerator.Current);
            Console.WriteLine();
        }
    }
}
