using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Overloading_With_different_Parametres
    {
        static void Main(string[] args)
        {
         MyClass obj= new MyClass();
            obj.Print();
            obj.print(10);
        }
    }

    //Overloading with different Number of parameters

    class MyClass
    {
        internal void Print()
        {
            Console.WriteLine("Zero parameters Print is calling");
        }   
        internal void print(int a)
        {
            Console.WriteLine("one parameter print is calling" + a);
        }
    }
    //Overloading with different Type of parameters
    class MyClass1
    {
        internal void print(int a)
        {
            Console.WriteLine("A value is"+a);
        }
        internal void print(string s)
        {
            Console.WriteLine("S value is " + s);
        }
    }
}
