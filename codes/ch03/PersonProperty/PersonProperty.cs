using System;
class Person
{
    //private string myName ="N/A";
    //private int myAge = 0;

    public string Name { get; set; }

    public int Age { get; set; }

    public string Info
    {
		get
		{
			return "Name:" + Name + ",Age:" + Age;
		}
    }

    public static void Main()
    {
        Console.WriteLine("Simple Properties");

        Person person = new Person();
        person.Age = 20;
        person.Name = "mmm";
        //person.Info = "asdf";

        Person person2 = new Person(){
            Name = "Joe",
            Age = 99
        };
        Console.WriteLine( person.Info);
        person.Age += 1;
        Console.WriteLine( person.Info );
    }
}
