//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_Asending_Decending
//    {
//        static void Main(string[] args)

//        {
//            Console.WriteLine("Enter how many numbers want to store : ");
//            int n=int.Parse(Console.ReadLine());
//            int[] numbers = new int[n];
//            for(int i = 0; i < n; i++)
//            {
//                Console.Write($"Enter number {i + 1}: "); 
//                numbers[i]=int.Parse(Console.ReadLine());
//            }

//            //Ascending order using bubble sort 
//            for(int i = 0; i < n - 1; i++)
//            {
//                for(int j = 0; j < n - i - 1; j++)
//                {
//                    if (numbers[j] > numbers[j + 1])
//                    {
//                        int temp=numbers[j];
//                        numbers[j]=numbers[j+1];
//                        numbers[j+1]=temp; 
//                    }
//                }
//            }
//            Console.WriteLine("\n Numbers in Ascending Order : ");
//            for(int i = 0; i < n; i++)
//            {
//                Console.Write(numbers[i] + " ");
//            }
//            Console.WriteLine("\n Numbers in Decending Order : ");
//            for(int i = n - 1; i >= 0; i--)
//            {
//                Console.Write(numbers[i] + " ");
//            }


//        }
//    }
//}
