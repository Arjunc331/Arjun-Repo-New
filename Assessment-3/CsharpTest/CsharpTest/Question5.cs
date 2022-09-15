using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    internal class Question5
    {
        public static void Main()
        {

            String str = "TesTing AbcD";
            int upper = 0, lower = 0;
            String[] strArray = str.Split(' ');

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;
            }
            Console.WriteLine("Upper case letters : " + upper);
            Console.WriteLine("Lower case letters : " + lower);
            Console.WriteLine("Words : " + strArray.Length);
        }
    }
}
}
