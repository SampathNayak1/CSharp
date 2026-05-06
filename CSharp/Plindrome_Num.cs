//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Plindrome_Num
//    {
//        static void Main(string[] args)
//        {
//            int num, temp, rem, sum = 0;
//            Console.WriteLine("Enter a number : ");
//            num = Convert.ToInt32(Console.ReadLine());
//            temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                sum = (sum * 10) + rem;
//                num = num / 10;
//            }
//            if (temp == sum)
//            {
//                Console.WriteLine("It is a Palindrome.");
//            }
//            else
//            {
//                Console.WriteLine("It is Not a Palindrome");
//            }
//        }
//    }
//}
