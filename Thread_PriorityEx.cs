//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Thread_PriorityEx
//    {
//        static void Method1()
//        {
//            for(int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Heightest Priority Thread");
//            }
//        }
//        static void Method2()
//        {
//            for(int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Lowset Priority Thread"); 
//            }
//        }
//        static void Method3()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Normal Priority Thread");
//            }
//        }
//        static void Method4()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Above Normal Priority Thread");
//            }
//        }
//        static void Method5()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Below Normal Priority Thread");
//            }
//        }
//        static void Main(string[] args)
//        {
//            Thread t1=new Thread(Method1);
//            Thread t2=new Thread(Method2);
//            Thread t3 = new Thread(Method3);
//            Thread t4 = new Thread(Method4);  
//            Thread t5 = new Thread(Method5);
//            t1.Priority = ThreadPriority.Highest;
//            t2.Priority = ThreadPriority.Lowest;
//            t3.Priority = ThreadPriority.Normal;
//            t4.Priority = ThreadPriority.AboveNormal;
//            t5.Priority = ThreadPriority.BelowNormal;
//            t1.Start();
//            t2.Start();
//            t3.Start();
//            t4.Start();
//            t5.Start();
//        }
//    }
//}
