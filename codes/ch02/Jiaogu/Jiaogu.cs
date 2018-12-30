using System;
class Jiaogu 
{
	public static void Main(string[] args) 
	{
		Console.Write("\n请输入一个数:");
		string s = Console.ReadLine();
		int a = int.Parse( s );

		while( a != 1 )
		{
			Console.Write( " " +a );
			if( a%2==1 ) a = a*3+1; else a /= 2;
		}
		Console.WriteLine(" " +a);
	}
}
