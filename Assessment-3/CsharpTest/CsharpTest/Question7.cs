
Method Overloading :

   
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

 

namespace csharpTest
{            
    public class Quetion7
    {
        public virtual void display()
        {
            Console.WriteLine("Baseclass Method is calling");
        }
    }
    public class derivedclass : Quetion7
    {
        public override void display()
        {
            Console.WriteLine("derived class method is calling");
        }
    }
    class mainclass
    {
        public static void Main(string[] args)
        {
            derivedclass dc = new derivedclass();
            dc.display();
            Console.ReadLine();
        }

    }
}