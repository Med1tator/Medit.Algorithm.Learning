using System;

namespace _001.Hailstone
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1 = HailStoneCompulate(42);
            int l2 = HailStoneCompulate(7);
        }

        /// <summary>
        /// HailStone(n)    = {n}                       n <= 0
        ///                 = {n} U {Hailstone(n/2)}    n is even number
        ///                 = {n} U {Hailstone(3n+1)}   n is odd number
        /// 例如：{42,21,64,32,...,1}      求结果集的长度   
        /// </summary>
        static int HailStoneCompulate(int n)
        {
            int length = 1;
            while (n > 1)
            {
                n = (n % 2) == 0 ? n / 2 : (3 * n + 1);
                length++;
            }
            return length;
        }
    }
}
