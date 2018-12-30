using System;
public struct Point 
{
   public int x, y;

   public Point(int x, int y) 
   {
      this.x = x;
      this.y = y;    
   }
}

class MainClass 
{
   public static void Main()  
   {
      // Initialize:   
      Point myPoint = new Point();
      Point yourPoint = new Point(10,10);
	  Point hisPoint;
	  hisPoint.x = 20;
	  hisPoint.y = 20;

      // Display results:
      Console.Write("My Point:   ");
      Console.WriteLine("x = {0}, y = {1}", myPoint.x, myPoint.y);
      Console.Write("Your Point: ");
      Console.WriteLine("x = {0}, y = {1}", yourPoint.x, yourPoint.y);
      Console.Write("His Point: ");
      Console.WriteLine("x = {0}, y = {1}", hisPoint.x, hisPoint.y);
   }
}
