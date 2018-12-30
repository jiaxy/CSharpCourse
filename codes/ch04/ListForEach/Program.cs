using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForEach
{
    class Program
    {

        delegate void Func(string n);

        static void Main(string[] args) {

            List<string> words = new List<string>(){
            "Apple", "Banana", "Orange", "Mango"
            };
            int letters = 0;

            //匿名方法
            //Func printf = delegate (string s) {
            //    Console.WriteLine(s);
            //};
            //lambda表达式
            //Func printf = (string s) => { Console.WriteLine(s); };
            //Func printf = (s) =>{Console.WriteLine(s);};
            Func printf = s => Console.WriteLine(s);
            foreach (string s in words) {
                printf(s);
            }
            //简写为
             words.ForEach(s => Console.WriteLine(s));

            Action<string> action = delegate (string s){
                Console.WriteLine(s);
            };
            words.ForEach(action);
            //匿名方法(使用局部变量)
            Func count = delegate (string s) {
                letters +=s.Length;
            };

            foreach (string s in words){
                count(s);
            }
            Console.WriteLine(letters);

            //lambda表达式
            words.ForEach(s => letters += s.Length);
            Console.WriteLine(letters);
        }
    }
}
