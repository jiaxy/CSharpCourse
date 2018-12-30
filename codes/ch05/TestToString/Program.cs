using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestToString
{
    class MyDate{
        protected int day, month, year;
        public MyDate(int i, int j, int k) {
            day = i;
            month = j;
            year = k;
        }
    }

    class MyOkDate : MyDate{
        public MyOkDate(int i, int j, int k)
            : base(i, j, k) { }
        public override string ToString() {
            return year + "-" + month + "-" + day;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            MyDate m1 = new MyDate(24, 3, 2001);
            MyDate m2 = new MyOkDate(24, 3, 2001);
            Console.WriteLine(m1); //显示MyDate
            Console.WriteLine(m2); //显示2001-3-24
        }
    }
}
