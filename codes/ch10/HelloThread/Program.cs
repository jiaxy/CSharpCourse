using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloThread
{
    class Program
    {
        bool quit = false;
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.Loop1();
            loopInThread(p);
        }
        
        private static void loopInThread(Program p)
        {
            new Thread(p.Loop2).Start();
            new Thread(p.LoopInput).Start();
        }


        void Loop1()
        {
            while (true)
            {
                Console.Out.WriteLine(DateTime.Now);
                Thread.Sleep(1000);
                if (Console.ReadLine() == "q")
                {
                    break;
                }
            }
        }

        void LoopInput()
        {
            while (Console.ReadLine() != "q") { }
            quit = true;
        }

        void Loop2()
        {
            while (!quit)
            {
                Console.Out.WriteLine("\n"+DateTime.Now);
                Thread.Sleep(1000);
            }
        }
    }
}
