using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
    class Program{
        static void Main(string[] args){
            int[] source = new int[1000000];
            for (int i = 0; i < source.Length; i++){
                source[i] = i;
            }
            Stopwatch sw = new Stopwatch();
            sw.Start();
            List<int> result = source.AsParallel()
                .Where(n=> n%2==0).ToList<int>();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
