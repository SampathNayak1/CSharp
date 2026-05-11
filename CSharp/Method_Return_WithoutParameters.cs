using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Method_Return_WithoutParameters
    {
        static void Main(string[] args)
        {
            MyClass obj=new MyClass();
           int result= obj.Sum();
            Console.WriteLine("Return value is "+result);

            string nameis = obj.YourName();
            Console.WriteLine("Your name is : " + nameis);
        }
    }
    class MyClass
    {
        public int Sum()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            return c;
        }
        
        public string YourName()
        {
            string name = "Sam";
            return name;
        }
    }
}
