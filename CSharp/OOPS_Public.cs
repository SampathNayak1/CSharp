//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class OOPS_Public
//    {
//        static void Main(string[] args)
//        {
//            C1 obj1c1=new C1();
//            obj1c1.Method1();
//            obj1c1.Method2();
//            C2 obj1c2=new C2();
//            obj1c2.Method3();

//        }
//    }
//    class C1
//    {
//        public void Method1()
//        {
//            Console.WriteLine("Method1 is calling");
//        }
//        internal void Method2()
//        {
//            Method1();
//            Console.WriteLine("Method2 is calling");
//        }
//    }
//    class C2
//    {
//        internal void Method3() 
//        {
//            C1 obj1c1=new C1();
//            obj1c1.Method1();
//            Console.WriteLine("Method3 is calling ");
//        }
//    }

//}
