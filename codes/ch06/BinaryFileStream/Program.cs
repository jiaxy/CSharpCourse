using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                FileStream ds = new FileStream("test.dat",
                    FileMode.Create, FileAccess.ReadWrite);

                BinaryWriter bw = new BinaryWriter(ds);

                //Write some data to the stream;
                bw.Write("A string");
                bw.Write(142);
                bw.Write(97.4);
                bw.Write(true);

                // Open it for reading;
                BinaryReader br = new BinaryReader(ds);
                // Move back to the start;
                br.BaseStream.Seek(0, SeekOrigin.Begin);
                // Read the data;
                Console.WriteLine(br.ReadString());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadBoolean());
            }catch (Exception e) {
                Console.WriteLine("Exception:" + e.ToString());
            }
        }
    }
}
