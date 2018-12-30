using System;
public class DeclareAssign
{
	public static void Main ( ) {
		bool b = true; 	//声明bool型变量并赋值	  	 
		int x, y=8; 	    	// 声明int型变量
		float f = 4.5f; 	// 声明float型变量并赋值
		double d = 3.1415; 	//声明double型变量并赋值
		char c; 		//声明char型变量
		c ='\u0031';		//为char型变量赋值        	
		x = 12; 		//为int型变量赋值 
        Console.WriteLine("b=" + b);
		Console.WriteLine("x=" + x);
		Console.WriteLine("y=" + y);
		Console.WriteLine("f=" + f);
		Console.WriteLine("d=" + d);
		Console.WriteLine("c=" + c);		
	}
}
