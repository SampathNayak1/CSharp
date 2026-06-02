//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_109_LOOP_Divide_By_Zero
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter First Number ");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter Second Number ");
//            int b = int.Parse(Console.ReadLine());

//            Calculate obj = new Calculate();
//            int res = obj.Div(a, b);
//            Console.WriteLine("Division result is : " + res);
//        }
//        class Calculate
//        {
//            internal int Div(int x, int y)
//            {
//                while (y == 0)
//                {
//                    Console.WriteLine("Please enter second number other than zero");
//                    y = int.Parse(Console.ReadLine());
//                }
//                int z = x / y;
//                return z;
//            }
//        }
//    }
//}
