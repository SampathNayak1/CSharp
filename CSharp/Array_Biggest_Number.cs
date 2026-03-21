//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_Biggest_Number
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number of numbers :  "); ;
//            int n = int.Parse(Console.ReadLine());
//            int[] numbers = new int[n];

//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.Write($"Enter number is {i + 1} : ");
//                numbers[i] = int.Parse(Console.ReadLine());
//            }
//            Console.WriteLine("Find Heighest Number : ");

//            int highest = numbers[0];
//            for (int i = 1; i < numbers.Length; i++)
//            {

//                if (numbers[i] > highest)
//                {
//                    highest = numbers[i];
//                }
//            }
//            Console.WriteLine("Highest number is: " + highest);
//            Console.ReadLine();
//        }
//    }

//}
