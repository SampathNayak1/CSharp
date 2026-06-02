//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_108_OOPS_Calculation
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter First Number ");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Second Number ");
//            int b = int.Parse(Console.ReadLine());
//            Calculate obj = new Calculate();
//            obj.Add(a, b);
//            obj.Sub(a, b);
//           int mul= obj.Mul(a, b);
//            Console.WriteLine("Mul result is : " + mul);
//           int div= obj.Div(a, b);
//            Console.WriteLine("Div result is : "+div) ;

//        }
//    }
//    class Calculate
//    {
//        internal void Add(int x, int y)
//        {
//            int z = x + y; ;
//            Console.WriteLine("Add result is : " + z);
//        }
//        internal void Sub(int x, int y)
//        {
//            int z = x - y; ;
//            Console.WriteLine("Sub result is : " + z);
//        }
//        internal int Mul(int x, int y)
//        {
//            int z = x * y;
//            return z;
//        }
//        internal int Div(int x, int y)
//        {
//            int z = x / y;
//            return z;
//        }

//    }
//}