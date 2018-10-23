using System;
using static System.Console;

namespace _003.Distinct
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5 };
           int[] result =Distinct(nums);
            for (int i = 0; i < result.Length; i++)
            {
                WriteLine(result[i]);
            }
        }

        /// <summary>
        /// 有序向量的去重操作 高效版
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int[] Distinct(int[] arr)
        {
            int i = 0, j = 0;
            while (++j<arr.Length)
            {
                if (arr[i] != arr[j])
                    arr[++i] = arr[j];
            }
            Array.Resize(ref arr, ++i);
            return arr;
        }
    }
}
