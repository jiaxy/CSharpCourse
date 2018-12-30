using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelInvoke
{
    class Program{
        static void Main(string[] args){
            Parallel.Invoke(new Action[]{
                    ()=> DoSometing(1),
                    ()=> DoSometing(2)});
        }

        static void DoSometing(int i)
        {
            Console.WriteLine("i="+i);
            Thread.Sleep(2000);
        }
    }
}
