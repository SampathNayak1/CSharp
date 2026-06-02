//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class ThreadCalcuation
//    {
        
//        static void Add()
//        {
//            int a = 20;
//            int b = 10;
//            Console.WriteLine("Addtion of A And B is : " +(a+b));
//        }
//        static void Sub()
//        {
//            int a = 20;
//            int b = 10;
//            Console.WriteLine("Subtraction of A And B is : " + (a - b));
//        }
//        static void Mul()
//        {
//            int a = 20;
//            int b = 10;
//            Console.WriteLine("Multiplication of A And B is : " + (a * b));
//        }
//        static void Div()
//        {
//            int a = 20;
//            int b = 10;
//            Console.WriteLine("Division of A And B is : " + (a / b));
//        }
//        static void Main(string[] args)
//        {
//            Thread t1=new Thread(Add);
//            Thread t2=new Thread(Sub);
//            Thread t3=new Thread(Mul);
//            Thread t4=new Thread(Div);

//            t1.Start();
//            t2.Start();
//            t3.Start();
//            t4.Start();

//            t1.Join();
//            t2.Join();
//            t3.Join();
//            t4.Join();
//        }
//    }
//}
