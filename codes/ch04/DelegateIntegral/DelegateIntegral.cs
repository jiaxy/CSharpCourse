using System;



public class DelegateIntegral
{
    delegate double Fun(double x); //申明一个委托

    public static void Main()
	{
        Fun fun = new Fun(Math.Sin);
		double d = Integral( fun, 0, Math.PI/2, 1e-4 ); 
		Console.WriteLine( d );

        Fun fun2 = new Fun(Linear);
		double d2 = Integral( fun2, 0, 2, 1e-3 );
		Console.WriteLine( d2 );

        Rnd rnd = new Rnd();
		double d3 = Integral( new Fun(rnd.GetNextNum), 0, 1, 0.01 ); 
		Console.WriteLine( d3 );
	}
	
	static double Linear( double a )
	{
		return a*2+1;
	}

	static double Integral(Fun f, double a, double b, double eps)// 积分计算
	{
		int n,k;
		double fa,fb,h,t1,p,s,x,t=0;

		fa=f(a); 
		fb=f(b);

		// 迭代初值
		n=1; 
		h=b-a;
		t1=h*(fa+fb)/2.0;
		p=double.MaxValue;

		// 迭代计算
		while (p>=eps)
		{ 
			s=0.0;
			for (k=0;k<=n-1;k++)
			{ 
				x=a+(k+0.5)*h;
				s=s+f(x);
			}

			t=(t1+h*s)/2.0;
			p=Math.Abs(t1-t);
			t1=t; 
			n=n+n; 
			h=h/2.0;
		}
		return t;
	}
}

class Rnd
{
    Random r = new Random();
    public double GetNextNum(double x) {
        return r.NextDouble();
    }
}