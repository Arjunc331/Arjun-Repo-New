using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest
{
    internal class Question8
    {
        public static List<int> Sort(string type, List<int> data)
        {

            data.Sort();
            if (String.Equals("Ascending", type))
            {
                data.Reverse();
            }
            return data;
        }
    }
}
