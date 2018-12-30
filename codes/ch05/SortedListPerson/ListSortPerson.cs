using System;
using System.Collections.Generic;
public class ListSortPerson
{

    class MyClass<T>
    {
        public  bool equals(T o1,T o2) {
            return o1.Equals(o2);
        }

    }
    public struct Person : IComparable
    {
        public string Name { set; get; }
        public bool Sex{ set; get; }
        public int Age { set; get; }

        public Person(string name, bool sex, int age) {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public int CompareTo(object obj2) {
            if (!(obj2 is Person))
                throw new System.ArgumentException();
            Person rec2 = (Person)obj2;
            return this.Age - rec2.Age;
        }

        public override string ToString() {
            return "Name:" + Name + "\tSex:" + Sex + "\tAge:" + Age;
        }
    }

    public class MyComparer : IComparer<Person>
    {
        public int Compare(Person p1, Person p2) {
            return p1.Name.ToLower().CompareTo(p2.Name.ToLower());
        }
    }


    public static void Main() {
        List<Person> persons = new List<Person>() {
            new Person( "Li ", true, 12 ),
            new Person( "Tang", false, 23 ),
            new Person( "Zhang", true, 18 ),
            new Person( "Chen", false, 37 ),
        };

        Console.WriteLine("original array:");
        persons.ForEach(p => Console.WriteLine(p));

        Console.WriteLine("sort by age:");
        persons.Sort();
        persons.ForEach(p => Console.WriteLine(p));

        Console.WriteLine("sort by name:");
        persons.Sort(new MyComparer());
        persons.ForEach(p => Console.WriteLine(p));

        Console.WriteLine("sort by age:");
        persons.Sort((p1, p2) => p1.Age - p2.Age);
        persons.ForEach(p => Console.WriteLine(p));
    }

   

}
