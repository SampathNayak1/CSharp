//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_Multidimensioal_Addition
//    {
//        static void Main(string[] args)
//        {


//            Console.Write("Enter number of rows: ");
//            int rows = int.Parse(Console.ReadLine());

//            Console.Write("Enter number of columns: ");
//            int cols = int.Parse(Console.ReadLine());

//            int[,] array1 = new int[rows, cols];
//            int[,] array2 = new int[rows, cols];
//            int[,] result = new int[rows, cols];

//            // Input for Array 1
//            Console.WriteLine("\nEnter values for First Array:");
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    Console.Write($"Element [{i},{j}]: ");
//                    array1[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            // Input for Array 2
//            Console.WriteLine("\nEnter values for Second Array:");
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    Console.Write($"Element [{i},{j}]: ");
//                    array2[i, j] = int.Parse(Console.ReadLine());
//                }
//            }

//            // Adding arrays and storing in result
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    result[i, j] = array1[i, j] + array2[i, j];
//                }
//            }

//            // Display Result
//            Console.WriteLine("\nResultant Array (Sum):");
//            for (int i = 0; i < rows; i++)
//            {
//                for (int j = 0; j < cols; j++)
//                {
//                    Console.Write(result[i, j] + "\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    }


//}
