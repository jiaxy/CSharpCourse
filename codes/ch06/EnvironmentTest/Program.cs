using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            s += "\n当前程序名:\t"
                + Environment.GetCommandLineArgs()[0];
            s += "\n当前目录:\t"
                + Environment.CurrentDirectory;
            s += "\nWin操作系统:\t"
                + (Environment.OSVersion.Platform == PlatformID.Win32NT);
            s += "\n环境变量Temp:\t"
                + Environment.GetEnvironmentVariable("temp");
            s += "\n堆栈信息:\t"
                + Environment.StackTrace;
            s += "\n登录用户:\t"
               + Environment.UserName;
            Console.WriteLine(s);
        }
    }
}
