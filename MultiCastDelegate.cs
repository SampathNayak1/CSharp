//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class MultiCastDelegate
//    {
//        public delegate void Calculate();
//        static void Add()
//        {
//            Console.WriteLine("Enter First Number :");
//            int a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Second Number: ");
//            int b = Convert.ToInt32(Console.ReadLine());
//            int c = a + b;
//            Console.WriteLine("Addition of two numbers : " + c);
//        }
//        static void Sub()
//        {
//            Console.WriteLine("Enter First Number :");
//            int a = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Second Number: ");
//            int b = Convert.ToInt32(Console.ReadLine());
//            int c = a - b;
//            Console.WriteLine("Subtraction of two numbers : " + c);
//        }
//        static void Main(string[] args)
//        {
//            Calculate cal;
//            cal = Add ;
//            cal += Sub;
//            cal();

//        }
//    }
//}
