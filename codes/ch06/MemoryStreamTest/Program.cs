using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryStreamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                byte[] ary = { 33, 34, 35, 36, 37 };
                int b;

                MemoryStream msr = new MemoryStream(ary);
                MemoryStream msw = new MemoryStream();

                while ((b = msr.ReadByte()) != -1){
                    msw.WriteByte((byte)(b + 3));
                }
         
                byte[] result = msw.ToArray();
                Array.ForEach(result, bt => Console.WriteLine(bt));

            } catch (IOException e){
                Console.WriteLine("Exception:" + e.ToString());
            }
        }
    }
}
