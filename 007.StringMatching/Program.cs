using System;
using System.Collections;

namespace _007.StringMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "()",
                str2 = "(dfdsaf)(fds)",
                str3 = "((()afd()fd)fa((fdsfs)))",
                str4 = "())da()sda(()",
                str5 = ")(";

            Console.WriteLine($"str1 is matched? --:    {str1.IsBracketMatched('(', ')')}");
            Console.WriteLine($"str2 is matched? --:    {str2.IsBracketMatched('(', ')')}");
            Console.WriteLine($"str3 is matched? --:    {str3.IsBracketMatched('(', ')')}");
            Console.WriteLine($"str4 is matched? --:    {str4.IsBracketMatched('(', ')')}");
            Console.WriteLine($"str5 is matched? --:    {str5.IsBracketMatched('(', ')')}");

            Console.ReadKey();
        }
    }

    public static class StringExtensions
    {
        /// <summary>
        /// 括号匹配，用于比较()、[]、{}等
        /// </summary>
        /// <param name="str">用于比较的字符串</param>
        /// <param name="head">首符</param>
        /// <param name="tail">尾符</param>
        /// <returns>匹配：true；失配：false</returns>
        public static bool IsBracketMatched(this string str, char head, char tail)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            if (!str.Contains(head))
                return false;

            Stack stack = new Stack();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == head)
                    stack.Push(str[i]);     // 压入
                else if (str[i] == tail)
                {
                    if (stack.Count > 0)
                        stack.Pop();        // 弹出
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
