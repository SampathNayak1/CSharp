//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_Searching_Name_Age_Multi_Dimesinal
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter number of names : ");
//            int n = int.Parse(Console.ReadLine());

//            string[,] person = new string[n, 2];

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine($"Enter Details of person {i + 1} : ");
//                Console.Write("Name : ");
//                person[i, 0] = Console.ReadLine();

//                Console.Write("Age : ");
//                person[i, 1] = Console.ReadLine();
//            }
//            Console.WriteLine("\n Enter searching person name : ");
//            string sname = Console.ReadLine();
//            int position = -1;
//            for (int i = 0; i < n; i++)
//            {
//                if (person[i, 0] == sname)
//                {
//                    position = i;
//                    break;
//                }
//            }
//            if (position != -1)
//            {
//                Console.WriteLine("Name : " + person[position, 0]);
//                Console.WriteLine("Age : " + person[position, 1]);
//            }
//            else
//            {
//                Console.WriteLine("Record is not found");
//            }

//        }
//    }
//}
