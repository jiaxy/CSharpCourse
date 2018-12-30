using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEqualsObject
{
    class MyDate{
        public int day, month, year;
        public MyDate(int i, int j, int k) {
            day = i;
            month = j;
            year = k;
        }
    }

    class MyOkDate : MyDate{
        public MyOkDate(int i, int j, int k)
        : base(i, j, k) {
        }
        public override bool Equals(object obj) {
            if (obj is MyOkDate){
                MyOkDate m = (MyOkDate)obj;
                if (m.day == day && m.month == month && m.year == year)
                    return true;
            }
            return false;
        }
        public override int GetHashCode() {
            return year * 366 + month * 31 + day;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            MyDate m1 = new MyDate(24, 3, 2001);
            MyDate m2 = new MyDate(24, 3, 2001);
            Console.WriteLine(m1==m2); //不相等,显示false
            Console.WriteLine(m1.Equals(m2)); //不相等,显示false
            m1 = new MyOkDate(24, 3, 2001);
            m2 = new MyOkDate(24, 3, 2001);
            Console.WriteLine(m1.Equals(m2)); //相等,显示true
        }
    }
}
