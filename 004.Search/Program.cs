using System;

namespace _004.Search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 3, 5, 7, 7, 9, 11 };

            Console.Write($"Search1 result:{Search1(nums, 4)}");
        }

        /// <summary>
        /// 有序数组查找目标元素
        /// 减而治之，查找元素
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns>返回目标元素的位置</returns>
        static int Search1(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, middle;
            while (left < right)
            {
                middle = (left + right) / 2;
                if (target < arr[middle])
                    right = middle;
                else if (arr[middle] < target)
                    left = middle + 1;
                else
                    return middle;
            }

            return -1;
        }
    }
}
