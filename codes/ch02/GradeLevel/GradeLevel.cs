using System;
public class GradeLevel{
	public static void Main( ){
		Console.Write("Input Grade Level: ");
		char grade = (char) Console.Read();
		switch( char.ToUpper( grade ) ){
			case 'A' : 
				Console.WriteLine(grade+" is 85~100");
				break;
			case 'B' : 
				Console.WriteLine(grade+" is 70~84");
				break;
			case 'C' : 
				Console.WriteLine(grade+" is 60~69");
				break;
			case 'D' : 
				Console.WriteLine(grade+" is <60");
				break;
			default : 
				Console.WriteLine("input error");
				break;
		}
	}
}
