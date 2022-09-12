
Call by Value 
    when we call the method of any class by using object, the value of parameter in main method will directly copy to the class method to parameter value.
    The objects are called by value as Default, as a result whether it is a primitive data types or reference data types
    they are by default going to be called by value.

Example:

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

Call by Reference
    
    Here, when we call the method, the reference address of variable is passed to the method.
    If some changes occurs in values within the method that changes occurs in actual variable, to specify this parameter we use ref Keyword at the time of declaring as well as the calling method.

    Example:

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