//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices.ComTypes;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class ThreadLooping
//    {
//        static void Method1()
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.WriteLine("Thread1 " + i);
//            }
//        }
//        static void Method2()
//        {
//            for (int i = 1; i <= 5; i++)
//            {
//                Console.WriteLine("Thread2 " + i);
//            }
//        }
//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(Method1);
//            Thread t2 = new Thread(Method2);
//            t1.Start();
//            t2.Start();
//            t1.Join();
//            t2.Join();
//        }
//    }
//}
