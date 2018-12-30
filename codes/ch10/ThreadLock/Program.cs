using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLock
{
    class Program
    {
        static void Main(string[] args){
            Num num = new Num();
            Thread thread1 = new Thread(num.run);
            Thread thread2 = new Thread(num.run);
            thread1.Start();
            thread2.Start();
            for(int i = 0; i < 10; i++){
                Thread.Sleep(100);
                num.testEquals();
            }
        }
    }

    class Num
    {
        int x = 0;
        int y = 0;
       
        public void run(){
            while (true){
                lock (this){
                    x++;
                    y++;
                }
            }
        }


        public void testEquals()
        {
            lock (this){
               Console.WriteLine(x + "," + y + ":" + (x == y));
            }
        }

    }
}
