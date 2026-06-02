//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_MultiDimesional3
//    {
//        static void Main()
//        {
//            int[,] arr = new int[,] { {1,2,3,4,5 },{ 6,7,8,9,10},{ 11,12,13,14,15} };

//            //Print First row
//            for(int j = 0; j < arr.GetLength(1); j++)
//            {
//                Console.Write(arr[0,j]+" ");
//            }
//            Console.WriteLine();

//            //Prtint Second row
//            for(int j=0; j < arr.GetLength(1); j++)
//            {
//                Console.Write(arr[1, j] + " ");
//            }
//            Console.WriteLine();

//            //Print Third row

//            for (int j = 0; j < arr.GetLength(1); j++) 
//            {
//                Console.WriteLine(arr[2, j] + " ");
//            } 

//        }
//    }
//}
