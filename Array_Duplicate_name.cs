//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_Duplicate_name
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number of names : ");
//            int n = int.Parse(Console.ReadLine());
//            string[] names = new string[n];
//            for (int i = 0; i < n; i++)
//            {
//                Console.Write($"Enter name {i + 1}: ");
//                names[i] = Console.ReadLine();
//            }
//            bool duplicateFound = false;
//            Console.WriteLine("Duplicate Name : ");
//            for (int i = 0; i < names.Length; i++)
//            {
//                for (int j = i + 1; i <= names.Length; j++)
//                {
//                    if (names[i] == names[j])
//                    {
//                        Console.Write(names[i]);
//                        duplicateFound = true;
//                        break;
//                    }
//                }
//            }
//            if (!duplicateFound)
//            {
//                Console.WriteLine("Duplicate is not found. ");
//            }
//        }
//    }
//}
