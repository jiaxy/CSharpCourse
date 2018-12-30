using System;
public class LeapYear{
	public static void Main( ){

		Console.Write( "Input year:");
		string s = Console.ReadLine();
		int year = int.Parse(s);
		if( (year%4==0 && year%100!=0) || year%400==0)
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        } 
			
	}
}
