using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

class ParallelLoopMatrix
{
	static void Main(string[] args)
	{
		int m = 100, n=400, t=1000;
		double[,] matricA = new double[m,n];
		double[,] matricB = new double[n,t];
		double[,] result1 = new double[m,t];
		double[,] result2 = new double[m,t];
		InitMatrix(matricA);
		InitMatrix(matricB);
		InitMatrix(result1);
		InitMatrix(result2);

		Console.WriteLine("矩阵乘法");
        Stopwatch sw = new Stopwatch();
		sw.Start();
		MultiMatrixNormal(matricA, matricB, result1 );
        sw.Stop();
		Console.WriteLine("普通方法用时"+sw.ElapsedMilliseconds);

		sw.Restart();
		MultiMatrixParallel(matricA, matricB, result2 );
        sw.Stop();
		Console.WriteLine("并行方法用时"+sw.ElapsedMilliseconds);

		bool ok = CompareMatrix(result1, result2);
		Console.WriteLine("结果相同"+ok);
	}
	static Random rnd = new Random();
	static void InitMatrix(double[,] matric)
	{
		int m = matric.GetLength(0);
		int n = matric.GetLength(1);
		for(int i=0; i<m; i++) 
		{
			for( int j=0; j<n; j++ )
			{
				matric[i,j] = rnd.Next();
			}
		}
	}
	static void MultiMatrixNormal( double [,] matricA,  
                                    double [,] matricB,  double [,] result)
	{
		int m = matricA.GetLength(0); //矩阵A的行数
		int n = matricA.GetLength(1); //矩阵A的列数
        int t = matricB.GetLength(1); //矩阵B的列数
		//Console.WriteLine(m+","+n+","+t);

		for(int i=0; i<m; i++)
		{
			for( int j=0; j<t; j++)
			{
				double temp = 0;
				for( int k=0; k<n; k++ )
				{
					temp += matricA[i,k] * matricB[k,j];
				}
				result[i,j] = temp;
			}
            //Console.WriteLine($"第{i}行计算完毕");
        }
    }
	static void MultiMatrixParallel( double [,] matA,  double [,] matB,  double [,] result)
	{
		int m = matA.GetLength(0);
		int n = matA.GetLength(1);
		int t = matB.GetLength(1);

        //矩阵A每一行创建一个任务，然后并行执行
        Parallel.For(0, m, i => 
		{
			for( int j=0; j<t; j++)
			{
				double temp = 0;
				for( int k=0; k<n; k++ )
				{
					temp += matA[i,k] * matB[k,j];
				}
				result[i,j] = temp;
			}
            Console.WriteLine($"第{i}行计算完毕");
		});
    }
	static bool CompareMatrix( double [,] matA,  double [,] matB)
	{
		int m = matA.GetLength(0);
		int n = matA.GetLength(1);	
		for(int i=0; i<m; i++)
		{
			for( int j=0; j<n; j++)
			{
				if(Math.Abs(matA[i,j]-matB[i,j])>0.1 ) return false;
			}
		}
		return true;
	}
}