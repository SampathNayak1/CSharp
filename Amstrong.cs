//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Amstrong
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number :");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int rem, temp, sum = 0;
//            temp = num ;
//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = sum + (rem * rem * rem);
//                num = num / 10;
//            }
//            if (temp == sum)
//            {
//                Console.WriteLine(sum + "is an Amstrong number");
//            }
//            else
//            {
//                Console.WriteLine(sum + "is not a anstrong number");
//            }
//        }
//    }
//}
