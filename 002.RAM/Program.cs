using System;

namespace _002.RAM
{
    class Program
    {
        static void Main(string[] args)
        {
            int r1 = RAMCompulate(12, 2);
            int r2 = RAMCompulate(7, 3);
        }

        /// <summary>
        /// 计算非负整数c下正整数d的最大除数
        /// 例如：a=11 b=2 则结果为6；a=7 b=3 则结果为2
        /// </summary>
        /// <returns></returns>
        static int RAMCompulate(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new Exception("arguments is not legal.(a>=0 and b>0)");

            int result = 0;
            while (a - b >= 0)
            {
                a -= b;
                result++;
            }
            return result;
        }
    }
}
