class Test
{
	int x;
	static int y;
	void F() {
		this.x = 1;			// Ok，相当于 this.x = 1
		Test.y = 1;			// Ok，相当于 Test.y = 1
	}
	static void G() {
		//x = 1;			// 错误，不能访问 this.x
		Test.y = 1;			// Ok，相当于 Test.y = 1
	}
	static void Main() {
		Test t = new Test();
		t.x = 1;		// Ok
		//t.y = 1;		// 错误，不能用对象名访问static成员
		//Test.x = 1;		// 错误，不能用类名访问实例成员
		Test.y = 1;		// Ok
        t.F();
        Test.G();
	}
}
