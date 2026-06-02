using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class MyClass
    {
        static int count = 0;
        public MyClass()
        {
            count ++;
        }
        public void DisplayCount()
        {
            Console.WriteLine("Count is "+ count);
        }
       
    }  
    internal class StaticVariable
    {
        static void Main(string[] args)
        {
            MyClass mc =new MyClass(); 
            mc.DisplayCount();
            MyClass mc2 = new MyClass();
            mc2.DisplayCount(); 
             
        }
    }
}
