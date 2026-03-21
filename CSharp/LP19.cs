//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LP19
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number ");
//            int num = int.Parse(Console.ReadLine());
//            int rem = 0;
//            int palindrome = 0;
//            int temp = num;
//            while (num > 0)
//            {
//                rem = num % 10;
//                palindrome = palindrome * 10 + rem;
//                num = num / 10;
//            }
//            Console.WriteLine(palindrome);
//            if (palindrome == temp)
//            {
//                Console.WriteLine("It is an palindrome");
//            }
//            else
//            {
//                Console.WriteLine("It is not a plindrome");
//            }
//        }
//    }
//}
