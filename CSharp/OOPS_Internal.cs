//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class OOPS_Internal
//    {
//        static void Main(string[] args)
//        {
//            C1 obj1=new C1();
//            Console.WriteLine("Main method value is : " + obj1.a);
//            obj1.Method1();
//            C2 obj2=new C2();
//            obj2.method2();
//        }
//    }
//    class C1
//    {
//        internal int a = 10;
//        public void Method1()
//        {
//            Console.WriteLine("Method1 valuse is : " + a);
//        }
//    }
//    class C2
//    {
//        public void method2()
//        {
//            C1 obj = new C1();
//            Console.WriteLine("Method2 value is : " + obj.a);
//        }
//    } 
//}
