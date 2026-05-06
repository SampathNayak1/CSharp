//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class AmstrongNumber
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number : ");
//            int num = Convert.ToInt32(Console.ReadLine());
//            int temp, rem, sum = 0;
//            temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = sum + (rem * rem * rem);
//                num = num / 10;
//            }
//            if (temp == sum)
//            {
//                Console.WriteLine(temp + " it is an amstrong number");
//            }
//            else
//            {
//                Console.WriteLine(temp + " it is not an amstong number");
//            }

//        }
//    }
//}
