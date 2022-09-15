


Example Call by Value :

using System;
namespace CallByValueExample
{
    class Program
    {
        public static void Increment(int i)
        {
            i++;
        }
        static void Main(string[] args)
        {
            int x = 100;
            Increment(x);
         
        }
    }
}


    Example Call by Reference :

using System;
namespace CallByReferenceExample
{
    class Program
    {
        public static void IncrementValue(ref int i)
        {
            i++;
        }
        static void Main(string[] args)
        {
            int x = 100;
            IncrementValue(ref x);
        }
    }
}