using System;
public class MyStack<T>
{
	private T[] buffer;
	private int index = 0;
	private int size;
	public MyStack(int size=100){
		buffer = new T[size];
		this.size = size;
	}
	public void Push(T data){
		if(index>=size) throw new Exception();
		buffer[index++] = data;
	}
	public T Pop(){
		if(index==0) throw new Exception();
		return buffer[--index];
	}
	public bool IsEmpty()
	{
		return index==0;
	}
}
class Program{
	static void Main(){
		MyStack<string> stack = new MyStack<string>();
		stack.Push( "aaa");
		stack.Push( "bbbb" );
		stack.Push( "ccccc" );
		while(!stack.IsEmpty()){
			string a = stack.Pop();
			System.Console.WriteLine(a);
		}
	}
}