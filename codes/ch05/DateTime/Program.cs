using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime
{
    class Program
    {
        static void Main(string[] args) {
            System.DateTime today = System.DateTime.Now;
            System.TimeSpan duration = TimeSpan.Parse("36.00:00:00");//36天
            System.DateTime answer = today+duration;
            System.TimeSpan period = answer - today;
            System.Console.WriteLine("{0}  {0:dddd}", answer, answer);
            
        }
    }
}
