//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Background_Thread
//    {
//        static void Method()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Background Thread is running ...." + i);
//                Thread.Sleep(1000);
//            }
//        }
//        static void Main(string[] args)
//        {
//            Thread t = new Thread(Method);
//            t.IsBackground = true;
//            t.Start();
//            Console.WriteLine("Main thread is Started");
//            //Thread.Sleep(2000);
//            Console.WriteLine("Main thread is ended");

//        }
//    }
//}
