using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Demo
    {
        /// <summary>
        /// 完美数
        /// </summary>
        /// <param name="Max"></param>
        /// <returns></returns>
        public int[] Perfect(int Max)
        {
            List<int> result = new List<int>();

            for (int z = 2; z < Max; z++)
            {
                int sum = 0;
                for (int j = z - 1; j > 0; j--)
                {
                    if (z % j == 0)
                        sum += j;

                    if (j == 1)
                    {
                        if (sum == z)
                        {
                            result.Add(z);
                        }
                    }
                }
            }
            return result.ToArray();
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="y">传入未排序的数组</param>
        /// <returns>排序后的数组<</returns>
        public int[] InsertionSort(int[] y)
        {
            for (int k = 0; k < y.Length - 1; k++)
            {
                int b = y[k + 1];
                int j = k;
                while (j >= 0 && y[j] > b)
                {
                    y[j + 1]= y[j];
                    j--;
                }
                y[j + 1] = b;
            }
            return y;
        }

        /// <summary>
        /// 计算斐波那契数
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int Fabonacci(int a)
        {
            int result = 1;
            if (a == 0 || a == 1)
                result = 1;
            else result = Fabonacci(a - 1) + Fabonacci(a - 2);
            return result;
            
        }

        /// <summary>
        /// 计算index的阶乘
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Factoria(int index)
        {
            int result = 1;
            if (index == 0)
                return 1;
            result = index * Factoria(index - 1);
            while (index > 0)
            {
                result *= index;
                index--;
            }
            return result;
        }


    }
}
