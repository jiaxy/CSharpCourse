using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        private int cnt = 0;

        private void Count()
        {
            while (cnt < 10)
            {
                cnt++;
                Console.WriteLine(Thread.CurrentThread.Name + "数到" + cnt);
                Thread.Sleep(300);
            }
        }

        private void Count2(int n)
        {
            while (cnt < n)
            {
                cnt++;
                Console.WriteLine(Thread.CurrentThread.Name + "数到" + cnt);
                Thread.Sleep(300);
            }
        }


        static void Main()
        {
            Program obj1 = new Program();
            Thread thread1 = new Thread(obj1.Count);
            thread1.Name = "线程1";
            Thread thread2 = new Thread(obj1.Count);
            thread2.Name = "线程2";

            Program obj2 = new Program();
            Thread thread3 = new Thread(()=>obj2.Count2(15));
            thread3.Name = "线程3";

            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
