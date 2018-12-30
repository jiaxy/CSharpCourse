using System;
class Program
{
	static void Main(string[] args)
	{
		//初始化牌局
		int[] array = new int[52];
		for (int i = 0; i < array.Length; i++){
			array[i] = i;
		}
		//洗牌
		Shuffle<int>(array);

		//显示
		foreach( int n in array) Console.Write(n+" ");
	}

	static void Shuffle<T>(T[] array){
		Random random = new Random();
		for (int i = 1; i < array.Length; i++){
			Swap<T>(array, i, random.Next(0, i));
		}
	}

	static void Swap<T>(T[] array, int indexA, int indexB){
		T temp = array[indexA];
		array[indexA] = array[indexB];
		array[indexB] = temp;
	}
}
