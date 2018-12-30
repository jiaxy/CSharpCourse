using System;
using System.IO;
using System.Threading;


class Test
{
	static void Main()
	{
        ThreadPool.SetMaxThreads(3, 3); // 大于等于CPU核数, 2个工作线程、2个异步I/O线程
        int workerThreads, ioThreads;
        ThreadPool.GetMaxThreads(out workerThreads, out ioThreads);
        Console.WriteLine($"workerThreads：{workerThreads},completionThreads：{ioThreads}");

        for (int i = 1; i < 100; i++){
            ThreadPool.QueueUserWorkItem(new WaitCallback(Fun), i);
        }
        Console.ReadKey();
	}

	static void Fun(object obj )
	{
        int n = (int)obj;
        Console.WriteLine(
              $"当前值为：{n}," +
              $"线程ID={Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(200);
	}



}
