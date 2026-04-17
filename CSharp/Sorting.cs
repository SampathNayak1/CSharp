//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Sorting
//    {
//        static void Main(string[] args)
//        {
//            int[] intArray = { 50, 20, 70, 35, 10, 5 };
//            for (int i = 0; i <= intArray.Length - 1; i++)
//            {
//                for (int j = 0; j < intArray.Length - 1; j++)
//                {
//                    if (intArray[j] > intArray[j + 1])
//                    {
//                        int orgVal = intArray[j];
//                        intArray[j] = intArray[j + 1];
//                        intArray[j + 1] = orgVal;
//                    }
//                }
//            }
//            for (int i = 0; i <= intArray.Length - 1; i++)
//            {
//                Console.WriteLine($"index of {i} value  is {intArray[i]}");
//            }

//            // Using Array Method
//            //Array.Sort(intArray);
//            //for (int i = 0; i <= intArray.Length - 1; i++)
//            //{
//            //    Console.WriteLine(intArray[i]);
//            //}


//        }
//    }
//}
