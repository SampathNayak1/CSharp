using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Method_With_Parameters
    {
        static void Main(string[] args)
        {
            MyClass cls=new MyClass();
            cls.Greet(10);
            cls.Add(10, 20);
        }
    }
    class MyClass 
    {
        public void Greet(int x)
        {
            Console.WriteLine("X value is :"+x);
        }
        public void Add(int x, int y)
        {
            int c = x + y;
            Console.WriteLine("Addition of two nembers :" + c);
        }
    }
}
