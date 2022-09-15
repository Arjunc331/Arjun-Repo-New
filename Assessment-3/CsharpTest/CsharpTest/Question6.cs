


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