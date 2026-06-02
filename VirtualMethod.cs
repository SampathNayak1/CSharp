//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class MyClass
//    {
//        public void Display()
//        {
//            Console.WriteLine("Welcome to oops");
//        }
//        public virtual void Show()
//        {
//            Console.WriteLine("Show is calling"); 
//        }
//    }
//    class dc : MyClass
//    {
//        public void Message()
//        {
//            Console.WriteLine("Message is calling");
//        }
//        public override void Show()
//        {
//            Console.WriteLine("Show is overridden");
//        }
//        internal class VirtualMethod
//        {
//            static void Main(string[] args)
//            {
//                MyClass obj= new MyClass();
//                obj.Display();
//                obj.Show();
//                dc objdc=new dc();
//                objdc.Message();
//                objdc.Show();
//            }
//        }
//    }
//}
