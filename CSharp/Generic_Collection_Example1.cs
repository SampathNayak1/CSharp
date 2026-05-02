//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Generic_Collection_Example1
//    {
//        static void Main(string[] args)
//        {
//            Myclass obj = new Myclass();
//            obj.Add<int>(100);
//            obj.Add<String>("Sam");
//            obj.Add<double>(1000);
//            obj.Add1<int>(10, 20,30);
//            obj.Add1<int>(10, 20,30);
//            obj.Sub<decimal>(100.00m);
//            obj.Student<int, string>(10, "Rama");
//        }
//    }

//    class Myclass
//    {
//        public void Add<T>(T x)
//        {
//            Console.WriteLine(x);
//        }
//        public void Add1<T>(T a, T b ,T c)
//        {
                
//            Console.WriteLine(a + "," + b);
//        }
//        public void Sub<T>(T a)
//        {
//            Console.WriteLine(a);
//        }
//        public void Student<T, k>(T a, k b)
//        {
//            Console.WriteLine(a + "," + b);
//        }

//    }
//}
