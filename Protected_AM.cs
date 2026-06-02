//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Protected_AM
//    {
//        class MyClass
//        {
//             protected int a = 10;

//            public void Method1()
//            {
//                Console.WriteLine("Method1 is calling " +a);
//            }
//        }
//        class MyClass2:MyClass 
//        {
//            public void Method2()
//            {
//                Console.WriteLine("Method2 is calling "+a);
//            }
//        }
//        static void Main(string[] args)
//        {
//            MyClass2 cl=new MyClass2();
//            cl.Method1();
//            cl.Method2();
//        }
//    }
//}
