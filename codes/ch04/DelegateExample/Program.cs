using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{

    // delegate int Fun(int num); //可以申明一个全局的委托
    class Program
    {
        delegate int Fun(int num); //申明一个委托

        static void Main(string[] args) {
            Fun fun1 = new Fun(AddOne); 
            Console.WriteLine(fun1(1));
            Program p = new Program();
            fun1 = new Fun(p.AddTwo);
            Console.WriteLine(fun1(1));


        }

        static int AddOne(int num) {
            return num + 1;
        }

        int AddTwo(int num) {
            return num + 2;
        }


    }
}
