using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databinding
{
    public class Student
    {
        public String Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public Student(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
    }
}
