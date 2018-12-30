using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<double>[] tasks = {
                 Task.Run( ()=>SomeFun() ),
                 Task.Run( ()=>SomeFun() ),
            };
            //Thread.Sleep(1);
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine(tasks[i].Status);  //查看状态
            }
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine(tasks[i].Result);  //等到计算结束取结果
            }
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine(tasks[i].Status);  //查看状态
            }
            //Task.WaitAll(tasks); //也可以用这句来等待结束
        }

        static double SomeFun()
        {
            Thread.Sleep(50);
            return DateTime.Now.Ticks;
        }
    }
}
