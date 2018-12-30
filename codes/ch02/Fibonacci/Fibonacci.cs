using System;
public class Fibonacci{
	public static void Main( string [] args ){
	int i;
	int [] f=new int[10];
	f[0]=f[1]=1;
	for( i=2; i<10; i++ )
		f[i]=f[i-1]+f[i-2];
	for( i=1; i<=10; i++ )
		Console.WriteLine("F["+i+"]= "+f[i-1]);
	}
}
