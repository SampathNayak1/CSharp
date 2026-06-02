//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class ThreadSimple
//    {
//        static void Method1()
//        {
//            Console.WriteLine("Thread1  ");
//        }
//        static void Method2()
//        {
//            Console.WriteLine("Thread2");
//        }
//        static void Main(string[] args)
//        {
//            Thread t1= new Thread(Method1);
//            Thread t2= new Thread(Method2);
//            t1.Start();
//            t2.Start();
//            t1.Join();
//            t2.Join();
//        }
//    }
//}
