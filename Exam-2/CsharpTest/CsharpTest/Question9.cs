using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    internal class Question9
    {
        public class HelloWorld
        {

            public static string removedupes(string s)
            {
                string newString = string.Empty;
                List<char> found = new List<char>();
                foreach (char c in s)
                {
                    if (found.Contains(c))
                        continue;

                    newString += c.ToString();
                    found.Add(c);
                }
                return newString;
            }
            public static void Main()
            {
                var result = removedupes("abbagfdcab");
                Console.WriteLine(result);

            }
        }
    }
}
