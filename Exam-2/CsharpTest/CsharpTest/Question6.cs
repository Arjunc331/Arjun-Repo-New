

using System.Xml.Linq;

Abstract Class:
Abstract class can have abstract and non abstract methods.
Abstract class does not support multiple inheritance.
Abstract class can have final, non-final, static and non-static variables.
Abstract class can provide the implementation of interface.

Interface:

Interface have only abstract methods, and it have default and static methods also.
Interface supports multiple inheritance.

Interface has only static and final variables.

Interface cant provide the implementation of abstract class.

   Example:

namespace CsharpTest
{
    interface IInter
    {
        void getdata();
        void putdata();
    }
    class Inter : IInter
    {
        int Id;
        string : Name;
            public void getdata()
        {
            Id = 101;
            Name = "Arjun";
        }
        public void putdata()
        {
            Console.WriteLine("Id Number is {0}", Id);
            Console.WriteLine("Name is :" + Name);
        }
    }
    internal class Question6
    {
        static void Main(string[] args)
        {
            IInter inter = new Inter();
            inter.GetData();
            inter.PutData();
        }
    }
}