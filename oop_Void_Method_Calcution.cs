//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class oop_Void_Method_Calcution
//    {
//        static void Main()
//        {
//            Console.WriteLine("Enter a first number ");
//            int x = int.Parse(Console.ReadLine()); ;
//            Console.WriteLine("Enter a second number ");
//            int y = int.Parse(Console.ReadLine());
//            Calculate obj = new Calculate();
//            obj.Add(x,y);
//            obj.Sub(x, y);
//            obj.Mul(x, y);
//            obj.Dvd(x, y);
//        }
//    }

//    class Calculate
//    {
//        internal void Add(int a, int b)
//        {
//            int c = a + b;
//            Console.WriteLine("Addition of two numbers : " + c); 
//        }
//        internal void Sub(int a,int b)
//        {
//            int c = a - b;
//            Console.WriteLine("Subraction of two number : " + c);
//        }
//        internal void Mul(int a,int b)
//        {
//            int c = a * b;
//            Console.WriteLine("Multiplication of two number : " + c);
//        }
//        internal void Dvd(int a, int b)
//        {
//            int c=a/b ;
//            Console.WriteLine("Division of two number : " + c);        }

//    }
//}
