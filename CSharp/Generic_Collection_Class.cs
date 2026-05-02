using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Generic_Collection_Class
    {
        static void Main(string[] args)
        {
            Myclass<int>  obj = new Myclass<int>(1000);
            obj.Display();

            Myclass<string> obj1 = new Myclass<string>("Rama");
            obj1.Display();

            Newclass<decimal> obj2 =new Newclass<decimal>(123.11m);
            obj2.NewDisplay();

            Newclass<double> obj3 = new Newclass<double>(10000);
            obj3.NewDisplay();
        }
    }

    class Myclass<T>
    {
        T a;
        internal Myclass(T a)
        {
            this.a = a;
        }
        internal void Display()
        {
            Console.WriteLine(" A Value is : " + a);
        }
    }
    class Newclass<T>
    {
        T b;
        
        internal Newclass(T b)
        {
            this.b = b;
        }
        internal void NewDisplay()
        {
            Console.WriteLine("B value is : "+b);
        }
    }
}
