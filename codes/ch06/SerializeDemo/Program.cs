using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = {
                new Person(),
                new Person() };

            BinaryFormatter binary = new BinaryFormatter();
            using (FileStream fs = new FileStream("s.temp", FileMode.Create)) {
                binary.Serialize(fs, persons);
            }

            using (FileStream fs = new FileStream("s.temp", FileMode.Open)){
                Person[] persons2 =(Person[])binary.Deserialize(fs);
                Array.ForEach(persons2, p => Console.WriteLine(p));
            }

            XmlSerializer xmlSerializer=new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("s.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, persons);
            }

            Console.WriteLine(File.ReadAllText("s.xml"));

            using (FileStream fs = new FileStream("s.xml", FileMode.Open))
            {
                Person[] persons3 =(Person[]) xmlSerializer.Deserialize(fs);
                Array.ForEach(persons3, p => Console.WriteLine(p));
            }







        }
    }
}
