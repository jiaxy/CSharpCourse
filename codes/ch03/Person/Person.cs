using System;
class Person
{
    string name;
    int age;

    Person(string name, int a) {
        this.name = name;
        this.age = a;
    }

    Person(string n) {
        name = n;
        age = -1;
    }

    Person() : this("", 0) {
    }

    public static void Main(string[] args) {
        Person person = new Person();

        
        
    }
}
