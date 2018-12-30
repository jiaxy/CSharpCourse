using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream fsw = new FileStream("test.dat",
                    FileMode.Create, FileAccess.Write);

                //Write some data to the stream;
                fsw.WriteByte(33);
                fsw.Write(new byte[] { 34, 35, 36 }, 0, 2);
                fsw.Close();

                FileStream fsr = new FileStream("test.dat",
                    FileMode.Open, FileAccess.Read);

                for (int b = fsr.ReadByte(); b!=-1; b = fsr.ReadByte()){
                    Console.WriteLine(b);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception:" + e.ToString());
            }
        }
    }
}
