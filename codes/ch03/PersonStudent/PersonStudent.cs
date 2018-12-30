using System;
class Person {
	public string name; //定义字段
	public int age;
	public virtual void sayHello(){ //定义方法，注意virtual
		Console.WriteLine("Hello!  My name is " + name );
	}
	public virtual void sayHello( Person another ){ //方法重载
		Console.WriteLine("Hello," + another.name + 
			"! My name is " + name );
	}
	public bool isOlderThan(int anAge){ //定义方法
		return (age > anAge);
	}
	public Person(string n, int a){ //构造方法
		name = n;
		age = a;
	}
	public Person(string n){ //构造方法重载
		name = n;
		age = -1;
	}
	public Person():this("", 0 )//调用其他构造方法
	{ 
	}
}

class  Student : Person  //定义子类
{
	public string school; //增加的字段
	public int score = 0;
	public bool isGoodStudent(){ //增加的方法
		return score>=90;
	}
	public override void sayHello(){ //重写同名方法
		base.sayHello();
		Console.WriteLine( "My school is " + school );
	}
	public void sayHello( Student another ){ //重载方法
		Console.WriteLine("Hi!");
		if( school == another.school ) 
			Console.WriteLine(" Shoolmates ");
	}
	public void testThisSuper(){
		int a;
		a = age;		//本句与以下两句效果相同
		a = this.age;	//使用this
		a = base.age;	//使用base
	}
	public Student(){  //构造方法
	}
	public Student(string name, int age, string school ) 
		: base( name, age ) //调用父类的构造方法
	{
		this.school = school;
	}

	public static void Main( string [] arggs )
	{
		Person p = new Person( "Liming", 50 );
		Student s = new Student( "Wangqiang", 20, "PKU" );
		Person p2 = new Student( "Zhangyi", 18, "THU" );
		Student s2 = (Student) p2; //类型转换
		s2.sayHello();
	}
}
