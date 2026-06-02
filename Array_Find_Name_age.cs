//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Array_Find_Name_age
//    {
//        static void Main(string[] args)
//        {
//            string[] names = new string[5];
//            byte[] ages = new byte[5];
//            for (int i = 0; i < names.Length; i++)
//            {
//                Console.Write("Enter your name : ");
//                names[i] = Console.ReadLine();
//                Console.Write("Enter you age : ");
//                ages[i] = byte.Parse(Console.ReadLine());
//            }

//            Console.WriteLine("Enter serching person name : ");
//            string find = Console.ReadLine();
//            int counter = 0;
//            for (int i = 0; i < names.Length; i++)
//            {
//                if (find == names[i])
//                {
//                    Console.WriteLine(find + " age is : " + ages[i]);
//                    counter++;
//                    break;
//                }
//            }
//            if (counter == 0)
//            {
//                Console.WriteLine("Searching person not found.");
//            }
//        }
//    }
//}
