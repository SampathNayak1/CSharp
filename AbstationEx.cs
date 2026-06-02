//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    abstract class AbstractClass
//    {
//        public void Start()
//        {
//            Console.WriteLine("Abstract Class has started");
//        }
//        public void Resume()
//        {
//            Console.WriteLine("Abstract class has resumed");
//        }
//        public void Display()
//        {
//            Console.WriteLine("Abstarct class has display");
//        }
//        public abstract void End();
//    }
//    class DerivedClas : AbstractClass
//    {
//        public override void End()
//        {
//            Console.WriteLine("Absstarct class has ended. ");
//        }
//    }
//    internal class AbstationEx
//    {
//        static void Main(string[] args)
//        {
//            AbstractClass obj=new DerivedClas();
//            obj.Start();
//            obj.Resume();
//            obj.Display();
//            obj.End();

//        }
//    }
//}
