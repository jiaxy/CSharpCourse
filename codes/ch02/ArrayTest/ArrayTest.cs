using System;
public class ArrayTest {
	public static void Main( string [] args ){
		int i;
		int [] a=new int[5];
        string s = @"c:\user\rb.exe";
        Console.WriteLine(s);
		for( i=0; i<a.Length; i++ )
			a[i]=i;
		foreach(int num in a )
			Console.WriteLine(num);
	}
}
