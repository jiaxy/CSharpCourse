using System;
class MyException : ApplicationException{
   	private int code;
 	public MyException(String message, int code) 
		:base(message){
			this.code = code;
 	} 

	public int Code { get => code; }
}

public class Test{
    public static void regist(int num) {
 	    if(num < 0) {
   			  Console.WriteLine("登记号码" + num );
 	          throw new MyException("号码为负值，不合理",3);
 	    }
    }
	public static void manager() {
 	    try {
	        regist(-100);
 	    } catch (MyException e) {
 	        Console.WriteLine("登记失败，出错种类" + e.Code);
	    }
	    Console.WriteLine("本次登记操作结束");
    }
	public static void Main(){
	    Test.manager();
    }
}
