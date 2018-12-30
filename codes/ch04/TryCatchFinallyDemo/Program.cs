using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTutorial
{
    class TryCatchFinallyDemo
    {
        public static void Main(string[] args) {
            String text = "001234A2";
            int value = toInteger(text);
            Console.WriteLine("Value= " + value);
            Console.Read();
        }

        public static int toInteger(String text) {
            try{
                Console.WriteLine("Begin parse text: " + text);
                // An Exception can throw here (FormatException).
                int value = int.Parse(text);
                return value;
            }catch (FormatException e){
                // In the case of 'text' is not a number.
                // This catch block will be executed.  
                Console.WriteLine("Number format exception: " + e.Message);
                return 0;
            }finally{
                Console.WriteLine("End parse text: " + text);
            }

        }
    }

}