using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClone
{
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber) {
            this.IdNumber = IdNumber;
        }
    }

    public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }

        public Person ShallowCopy() {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy() {
            Person other = (Person)this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = String.Copy(Name);
            return other;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            Person p1 = new Person(){
                Age = 42,
                Name = "Sam",
                IdInfo = new IdInfo(6565)
            };
           
            // Perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();

            // Display values of p1, p2
            Console.WriteLine("Original values of p1 and p2:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Change the value of p1 properties and display the values of p1 and p2.
            p1.Age = 32;
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1 and p2 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);

            // Make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();
            // Change the members of the p1 class to new values to show the deep copy.
            p1.Name = "George";
            p1.Age = 39;
            p1.IdInfo.IdNumber = 8641;
            Console.WriteLine("\nValues of p1 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p) {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}", p.Name, p.Age);
            Console.WriteLine("      Value: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
