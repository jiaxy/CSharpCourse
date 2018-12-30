using System;
class Rnd_36_7
{
	public static void Main(string[] args)
	{
		int []a = new int[7];
		Random random = new Random();
		for( int i=0;i<a.Length;i++)
		{
			one_num:
			while(true)
			{
				a[i] = random.Next( 36 ) +1;
				for( int j=0;j<i;j++ ){ 
					if( a[i]==a[j] ) goto one_num;
				}
				break;
			}
		}
		foreach( int n in a) Console.Write( " " + n ); 
		Console.WriteLine();
	}
}
