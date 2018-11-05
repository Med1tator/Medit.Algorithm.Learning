using System;

namespace _005.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 2, 9, 13, 7, 1, 9 };
            //new BubbleSorting().Sort(nums);
            new QuickSorting().Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} \t");
            }

            Console.ReadKey();
        }
    }


    /// <summary>
    /// 冒泡排序 时间复杂度为n*n
    /// </summary>
    class BubbleSorting
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }
    }

    /// <summary>
    /// 快速排序
    /// </summary>
    class QuickSorting
    {
        public void Sort(int[] arr)
        {
            int low = 0, high = arr.Length - 1;
            Sort(arr, low, high);
        }

        /// <summary>
        /// 递归 直至数组分割的足够小
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        private void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                var index = QuickSort(arr, low, high);
                Sort(arr, low, index - 1);
                Sort(arr, index + 1, high);
            }
        }

        /// <summary>
        /// 将数组分为大于某值和小于某值的两部分
        /// </summary>
        /// <param name="arr">待排序数组</param>
        /// <param name="low">下标开始位置，向右查找</param>
        /// <param name="high">下标开始位置，向左查找</param>
        /// <returns></returns>
        private int QuickSort(int[] arr, int low, int high)
        {
            var mark = arr[low];//作为基准数，取值范围[low,high-1]
            while (low < high)
            {
                while (low < high && arr[high] >= mark)
                    high--;
                arr[low] = arr[high];

                while (low < high && arr[low] <= mark)
                    low++;
                arr[high] = arr[low];
            }

            arr[low] = mark;
            return low;
        }
    }
}
