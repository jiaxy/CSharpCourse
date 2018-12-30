using System;

interface Runner 
{ 
	void run();
}

interface Swimmer 
{ 
	void swim();
}

abstract class Animal  
{	
	abstract public void eat();
}  

class Person : Animal , Runner, Swimmer 
{
	public void run() 
	{ 
		Console.WriteLine("run"); 
	}
	public void swim()  
	{
		Console.WriteLine("swim"); 
	}
	public override void eat() 
	{ 
		Console.WriteLine("eat"); 
	}
	public void speak()
	{
		Console.WriteLine("speak"); 
	}
}

class TestInterface
{
	static void m1(Runner r) 
	{ 
		r.run(); 
	}
	static void m2(Swimmer s) 
	{ 
		s.swim(); 
	}
	static void m3(Animal a) 
	{
		a.eat(); 
	}
	static void m4(Person p)
	{
		p.speak();
	}

	public static void Main(string [] args)
	{
		Person p = new Person();
		m1(p);
		m2(p);
		m3(p);
		m4(p);
	}
}
