using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class MyClass
    {
        int a;
        int b;
        public MyClass() 
        {
              a = 20;
              b = 10;
            Console.WriteLine("Constructor Called");
        }

        public void Greet()
        {
            Console.WriteLine("Greet is called");
            Console.WriteLine("a value is : " +a);
            Console.WriteLine("b value is : " + b);
        }
        public int Greet2() 
        {
            return a + b;
        }
        public int Sub()
        {
            return a - b;
        }
        public int Mul()
        {
            return a * b;
        }
        public int Div()
        {
            return a / b;
        } 
    internal class Constructor1
    {
            static void Main(string[] args)
            {
                MyClass obj=new MyClass();
                obj.Greet();
               int grt2= obj.Greet2();
                Console.WriteLine("Greet2 Result is : " + grt2);
                int subres= obj.Sub();
                Console.WriteLine("Sub result is : " + subres);
                int mulres=obj.Mul();
                Console.WriteLine("Mul result is : " + mulres);
                int divres=obj.Div();
                Console.WriteLine("Div result is : " + divres);
            }
        }
    }
}
