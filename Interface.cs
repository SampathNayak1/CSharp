//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    interface Iinterface1
//    {
//        // Interface1 Initialization of Variable
//        void Display();
//        void Print();
//    }
//    interface Iinterface2
//    {
//        // Interface2 Initialization of Variable 
//        void Show();
//    }
//    class DC : Iinterface1, Iinterface2
//    {
//        public void Display()
//        {
//            Console.WriteLine("Display Method is calling");
//        }
//        public void Print()
//        {
//            Console.WriteLine("Print Method is calling");
//        }
//        public void Show()
//        {
//            Console.WriteLine("Show Method is calling ");
//        }
//    }

//    internal class Interface
//    {
//        static void Main(string[] args)
//        {
//            Iinterface1 obj1 = new DC();
//            obj1.Display();
//            obj1.Print();
//            Iinterface2 obj2 = (Iinterface2)obj1;
//            obj2.Show();
//        }
//    }
//}
