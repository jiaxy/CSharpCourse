using System;
enum Color 
{
	Red,
	Yellow,
	Green
}
class TrafficLight
{
	public static void WhatInfo(Color color) {
		switch(color) {
			case Color.Red:
				Console.WriteLine(  "Stop!" );
				break;
			case Color.Yellow:
				Console.WriteLine(  "Warning!" );
				break;
			case Color.Green:
				Console.WriteLine(  "Go!" );
				break;
			default:
				break;
		}
	}
}

class Test
{
	static void Main()
	{
		Color c = Color.Red;
		Console.WriteLine( c );
		TrafficLight.WhatInfo( c );
	}
}
		
