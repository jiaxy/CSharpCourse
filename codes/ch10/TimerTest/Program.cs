using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerTest
{

    class TimerExampleState
    {
        public int counter = 0;
    }

    class App
    {
        public static void Main()
        {
            TimerExampleState s = new TimerExampleState();
            Timer timer = new Timer(CheckStatus,s , 1000, 500);
            Console.ReadKey();
            timer.Dispose();
            Console.WriteLine("counter="+s.counter);
            Console.ReadKey();
        }

        static void CheckStatus(object state)
        {
            TimerExampleState s = (TimerExampleState)state;
            s.counter++;
            Console.WriteLine("{0} Checking Status {1}.",
                DateTime.Now.TimeOfDay, s.counter);
            
        }
    }
}
