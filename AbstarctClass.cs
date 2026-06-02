
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    abstract class BC
//    {
//        //Property Declaraion 
//        internal abstract int X  
//        {
//            get;
//            set;
//        }
//        internal abstract void M1();

//        internal void Print()
//        {
//            Console.WriteLine("this is Non Abstact Method");
//        }  
//    }
//      class DC : BC 
//    {
//        int x;
//        internal override int X
//        {
//            get
//            {
//                return x;
//            }
//            set
//            {
//                x = value;
//            } 
//        }
//        internal override void M1()
//        {
//           Console.WriteLine("This is M1 Method");  
//        }
//    }

//    internal class AbstarctClass
//    {
//        static void Main(string[] args)
//        {
//            DC obj=new DC();
//            obj.M1();
//            obj.Print();
//            obj.X = 1;
//        }
//    }

//}
