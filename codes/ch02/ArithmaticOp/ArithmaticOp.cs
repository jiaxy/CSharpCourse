using System;
public class ArithmaticOp{
	public static void Main(  ){
		int a=5+4; //a=9
		int b=a*2; //b=18
		int c=b/4; //c=4
		int d=b-c; //d=14
		int e=-d; //e=-14
		int f=e%4; //f=-2
		double g=18.6; 
		double h=g%10; //h=2.6
		int i=3;
		int j=i++; //i=4,j=3
		int k=++i; //i=5,k=5
        int z = (int)(h + 0.5); //Àƒ…·ŒÂ»Î

        int x = 1;
        float y = 2.0f;
        Console.WriteLine((x - y).GetType());

     

  
        string s =@"c:\sab\file1";
		Console.WriteLine("a = "+a);
		Console.WriteLine("b = "+b);
		Console.WriteLine("c = "+c);
		Console.WriteLine("d = "+d);
		Console.WriteLine("e = "+e);
		Console.WriteLine("f = "+f);
		Console.WriteLine("g = "+g);
		Console.WriteLine("h = "+h);
		Console.WriteLine("i = "+i);
		Console.WriteLine("j = "+j);
		Console.WriteLine("k = "+k);
        Console.WriteLine("z = " + z);
    }
}
