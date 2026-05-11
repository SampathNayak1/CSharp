//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Star_Pyramind
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of rows for pyramid :");
//            int rows = Convert.ToInt32(Console.ReadLine());
//            for (int i = 1; i <= rows; i++)
//            {

//                for (int j = i; j < rows; j++)
//                {
//                    Console.Write(" ");

//                }
//                for (int k = 1; k <= (2 * i - 1); k++)
//                {
//                    if (k == 1 || k == (2 * i - 1) || i == rows)
//                    {
//                        Console.Write("*");
//                    }
//                    else
//                    {
//                        Console.Write(" ");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}
