
Method Overloading :

    Method overloading is to have multiple methods within the same class with the same name, but with different parameters.
    Each of these methods behave differently based on what is passed in it.

    Example:

    namespace CsharpTest
{
    internal class Question7
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public float Sum(float x, float y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Question7 Question7 = new Question7();
            Console.WriteLine("Sum of Two Integers is :" + Question7.Sum(10, 20));
            Console.WriteLine("Sum of Three Integers is :" + Question7.Sum(10, 20, 30));
            Console.WriteLine("Sum of Two Floats is  :" + Question7.Sum(1.2f, 2.3f));
        }
    }
}

Method Overriding :

    Method overriding is the ability to redefine the implementation of a method in a class that inherits from a parent class. When a method is overridden, the name and the parameters stay the same,
    but the implementation that gets called depends on the type of the object that is calling it.
    Method overriding is determined at runtime and is dynamic.