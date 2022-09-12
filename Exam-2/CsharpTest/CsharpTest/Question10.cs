using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    internal class Question10
    {
        public static stringReverseString1(string str)
        {
            char[] chars = str.ToCharArray();
            char[] result = newchar[chars.Length];
            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {
                result[i] = chars[j];
            }
            return new string(result);
        }
    }
}
