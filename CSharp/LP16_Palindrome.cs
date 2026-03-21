//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LP16_Palindrome
//    {
//        static void Main(string[] args)
//        {
//            int n, i, k, r, temp;
//            Console.Write("Enter Number : ");
//            n = int.Parse(Console.ReadLine());
//            Console.WriteLine("Palindrome numbers upto given range are:\n");
//            for (i = 1; i <= n; i++)
//            {
//                temp = i; r = 0;
//                while (temp != 0)
//                {
//                    k = temp % 10;
//                    r = r * 10 + k;
//                    temp = temp / 10;
//                }
//                if (r == i)
//                {
//                    Console.Write(i + " ");
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}
