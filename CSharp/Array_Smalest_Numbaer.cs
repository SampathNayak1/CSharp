//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_Smalest_Numbaer
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter numbers to find the smallest one :" );
//            int n=int.Parse(Console.ReadLine() );

//            int[] number=new int[n];
//            for(int i = 0; i < n; i++)
//            {
//                Console.Write($"Enter a number {i + 1} : ");
//                number[i] = int.Parse(Console.ReadLine());
//            }
//                int smallNo=number[0];
//            for(int i=0; i < number.Length; i++)
//            {
//                if (number[i] < smallNo)
//                {
//                    smallNo = number[i];
//                }
//            }
//            Console.WriteLine("Small number is : " + smallNo);
//        } 
//    }
//}
