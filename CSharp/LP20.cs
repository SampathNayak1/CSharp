//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LP20
//    {
//        static void Main(string[] args) 
//        {
//            Console.WriteLine("Enter a number");
//            int num = int.Parse(Console.ReadLine());
//            int rem = 0;
//            int sum = 0;

//            while (num > 9)
//            {
//                sum = 0;
//                while (num > 0)
//                {
//                    rem = num % 10;
//                    sum = sum + rem;
//                    num = num / 10;
//                }
//                num = sum;
//            }
//            Console.WriteLine(sum);

//        }
//    }
//}
