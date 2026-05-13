//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class SearchArray
//    {
//        static void Main(string[] args)
//        {
//            string[] name = new string[3];
//            int[] age = new int[3];
//            int[] marks=new int[3];
//            for(int i = 0; i < 3; i++)
//            {
//                Console.WriteLine("Enter Name :");
//                name[i] = Console.ReadLine();
//                Console.WriteLine("Enter Age : ");
//                age[i]=Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Enter marks :");
//                marks[i]=Convert.ToInt32 (Console.ReadLine());
//            }
//            Console.WriteLine("Enter Student name to search ");
//            string search = Console.ReadLine();
//            for(int j = 0; j < 3; j++)
//            {
//                if (name[j] == search)
//                {
//                    Console.WriteLine("Student Name is {0}", name[j]);
//                    Console.WriteLine("Student Age is {0}", age[j]);
//                    Console.WriteLine("Student mark are {0}", marks[j]);
//                } 
//            }
//        }
//    }
//}
