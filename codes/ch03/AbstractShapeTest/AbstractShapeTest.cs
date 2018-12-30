using System;

public abstract class Shape
{
   private string myId;

   public Shape(string s)
   {
      Id = s;   
   }

   public string Id //类型
   {
      get 
      {
         return myId;
      }

      set
      {
         myId = value;
      }
   }

   
   public abstract double Area //面积,抽象属性
   {
      get;
   }

    public abstract void Draw();

   public override string ToString() // 覆盖object的虚方法
   {
      return Id + " Area = " + string.Format("{0:F2}",Area);
   }
}

//正方形类
public class Square : Shape
{
   private int mySide; //边长

   public Square(int side, string id) : base(id)
   {
      mySide = side;
   }

   public override double Area	//实现面积
   {
      get
      {
         return mySide * mySide;
      }
   }

   public override void Draw() //覆盖绘制方法
   {
		Console.WriteLine( "Draw 4 Side:" + mySide );
   }
}

// 圆类
public class Circle : Shape
{
   private int myRadius; //半径

   public Circle(int radius, string id) : base(id)
   {
      myRadius = radius;
   }

   public override double Area  //实现面积
   {
      get
      {
         return myRadius * myRadius * System.Math.PI;
      }
   }

   public override void Draw() //覆盖绘制方法
   {
		Console.WriteLine( "Draw Circle:" + myRadius );
   }

}

//矩形类
public class Rectangle : Shape
{
   private int myWidth;
   private int myHeight;

   public Rectangle(int width, int height, string id) : base(id)
   {
      myWidth  = width;
      myHeight = height;
   }

   public override double Area
   {
      get
      {
         return myWidth * myHeight;
      }
   }

   public override void Draw() //覆盖绘制方法
   {
		Console.WriteLine( "Draw Rectangle" );
   }

}

//测试
public class TestClass
{
   public static void Main()
   {
      //Shape s = new Square(4,"sss");
      //s.Draw();
      //s = new Circle(3, "c");
      //s.Draw();

        Shape[] shapes =
         {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1")
         };
      
      System.Console.WriteLine("Shapes Collection");
      foreach(Shape s in shapes)
      {
         s.Draw();
         System.Console.WriteLine(s.Area);
      }
         
   }
}
