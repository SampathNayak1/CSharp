//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class OOPS_Protected
//    {
//        static void Main(string[] args)
//        {
//            C2 obj1c1=new C2();
//            obj1c1.Method2();
//            obj1c1.Show();        }
//    }
//    class C1
//    {
//        protected void Method1()
//        {
//            Console.WriteLine("Method1 is calling");
//        }
//        internal void Method2() 
//        {
//            Console.WriteLine("Method2 is calling");
//        }
//    }
//    class C2:C1
//    {
//        internal void Show()
//        {
//            Method1 ();
//            Console.WriteLine("Show is calling");
//        } 
//    }
//}
