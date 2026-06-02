//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Palindrome
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number to show the palindrome : ");
//            int palindrome = int.Parse(Console.ReadLine());
//            int reverse = 0;
//            int originalNumber = palindrome;
//            while (palindrome > 0)
//            {
//                int remainder = palindrome % 10;
//                reverse = reverse * 10 + remainder;
//                palindrome = palindrome / 10;
//            }
//            if (originalNumber == reverse)
//            {
//                Console.WriteLine("Palinderome");
//            }
//            else { Console.WriteLine("It is not a palindrome"); }
//        }
//    }
//}
