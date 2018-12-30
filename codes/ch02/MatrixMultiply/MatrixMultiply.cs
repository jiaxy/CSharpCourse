using System;
public class MatrixMultiply{
	public static void Main( string [] args ){
		int i,j,k;
		int [,] a = { {2,3,5}, {1,3,7} };
		int [,] b = { {1,5,2,8},{5,9,10,-3},{2,7,-5,-18} };
		int [,] c = new int[2,4];
		for( i=0; i<2; i++ ){
			for( j=0; j<4; j++ ){
				c[i,j]=0;
				for( k=0; k<3; k++ ){
					c[i,j]+=a[i,k]*b[k,j];
				}
			}
		}
		Console.WriteLine("\n*** Matrix A ***");
		for( i=0; i<2; i++ ){
			for( j=0; j<3; j++ )
				Console.Write(a[i,j]+" ");
			Console.WriteLine();
		}
		Console.WriteLine("\n*** Matrix B ***");
		for( i=0; i<3; i++ ){
			for( j=0; j<4; j++ )
				Console.Write(b[i,j]+" ");
			Console.WriteLine();
		}
		Console.WriteLine("\n*** Matrix C ***");
		for( i=0; i<2; i++ ){
			for( j=0; j<4; j++ )
				Console.Write(c[i,j]+" ");
			Console.WriteLine();
		}
	}
}
