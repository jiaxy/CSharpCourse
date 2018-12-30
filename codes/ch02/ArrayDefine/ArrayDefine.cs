class ArrayDefine
{
	static void Main() {
        int[] a1 = new int[3];
        a1[0] = 1;
        a1[1] = 2;
        a1[2] = 3;

		int[] a2 = new int[] {1, 2, 3};

        int[] a3 = { 1, 2, 3 };



 
		int[,] a2 = new int[,] {{1, 2, 3}, {4, 5, 6}};
		int[,,] a4 = new int[10, 20, 30];
		int[][] j2 = new int[3][];
		j2[0] = new int[] {1, 2, 3};
		j2[1] = new int[] {1, 2, 3, 4, 5, 6};
		j2[2] = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
	}
}
