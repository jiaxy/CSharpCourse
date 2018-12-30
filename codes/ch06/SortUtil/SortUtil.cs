using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch06
{
    public class SortUtil
    {
            public static void BubbleSort(int[] list)
            {
                bool flag = true;
                int temp = 0;
                for (int i = 0; i < list.Length - 1; i++)
                {
                    flag = true;
                    for (int j = 0; j < list.Length - i - 1; j++)
                    {
                        if (list[j] > list[j + 1])
                        {
                            temp = list[j];
                            list[j] = list[j + 1];
                            list[j + 1] = temp;
                            flag = false;
                        }
                    }
                    if (flag == true)
                        break;
                }
            }
    }
}
