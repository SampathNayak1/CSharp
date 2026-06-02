//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Task_92
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("Enter number of rows: ");
//            int n = Convert.ToInt32(Console.ReadLine());

//            int totalNumbers = n * (n + 1) / 2;  // Total numbers needed
//            int start = totalNumbers;

//            for (int i = n; i >= 1; i--)
//            {
//                start = start - i + 1;

//                for (int j = 0; j < i; j++)
//                {
//                    Console.Write(start + j + " ");
//                }

//                start = start - 1;
//                Console.WriteLine();
//            }
//        }
//    }
//}
