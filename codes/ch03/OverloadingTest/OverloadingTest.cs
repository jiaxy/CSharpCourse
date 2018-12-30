using System;
class OverloadingTest
{
	static void F() {
		Console.WriteLine("F()");
	}
	static void F(object o) {
		Console.WriteLine("F(object)");
	}
	static void F(int value) {
		Console.WriteLine("F(int)");
	}
	static void F(int a, int b) {
		Console.WriteLine("F(int, int)");
	}
	//static void F(int[] values) {
	//	Console.WriteLine("F(int[])");
	//}
	static void Main() {
		F();
		F(1);
        object n=1;
		F(n);
		F(1, 2);
		F(new int[] {1, 2, 3});
	}
}
