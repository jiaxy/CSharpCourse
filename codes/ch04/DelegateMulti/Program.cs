using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateMulti
{
    delegate void Func(int x);
    class ClassA
    {
        public static void M1(int i) {
            Console.WriteLine("ClassA.M1: " + i);
        }
        public static void M2(int i) {
            Console.WriteLine("ClassA.M2: " + i);
        }
        public void M3(int i) {
            Console.WriteLine("ClassA.M3: " + i);
        }
    }
    class Test
    {
        static void Main() {
            Func cd1 = ClassA.M1;
            cd1(-1);        // call M1
            Func cd2 = ClassA.M2;
            cd2(-2);        // call M2
            Func cd3 = cd1 + cd2;
            cd3(10);        // call M1 then M2
            cd3 += cd1;
            cd3(20);        // call M1, M2, then M1
            ClassA c = new ClassA();
            Func cd4 = c.M3;
            cd3 += cd4;
            cd3(30);        // call M1, M2, M1, then M3
            cd3 -= cd1;     // remove last M1
            cd3(40);        // call M1, M2, then M3
            cd3 -= cd4;
            cd3(50);        // call M1 then M2
            cd3 -= cd2;
            cd3(60);        // call M1
            cd3 -= cd2;     // impossible removal is benign
            cd3(60);        // call M1
            cd3 -= cd1;     // invocation list is empty
            Console.WriteLine(cd3 == null);
            //		cd3(70);	// System.NullReferenceException thrown
            cd3 -= cd1;     // impossible removal
            Console.WriteLine(cd3 == null);

        }
    }
}
