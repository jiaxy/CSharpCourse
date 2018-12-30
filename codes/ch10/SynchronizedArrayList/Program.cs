using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizedArrayList
{
    class Program
    {
        //ArrayList list = new ArrayList();
        ArrayList list = ArrayList.Synchronized(new ArrayList());

        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(p.AddElems);
            Thread t2 = new Thread(p.AddElems);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine(p.list.Count);
        }

        void  AddElems()
        {
            for(int i = 0; i < 10000; i++)
            {
                list.Add(i);
            }

        }
    }
}
