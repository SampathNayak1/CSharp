//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Switch_Calculator
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Simple calculator");
//            Console.Write("Enter 1 st Number : ");
//            int a=int.Parse(Console.ReadLine());
//            Console.Write("Enter 2 nd Number : ");
//            int b=int.Parse(Console.ReadLine());

//            Console.WriteLine("1-Addition");
//            Console.WriteLine("2-Subraction");
//            Console.WriteLine("3-Multiplication");
//            Console.WriteLine("4-Division"); 
//            int choice=int.Parse(Console.ReadLine());
//            switch (choice)
//            {
//                case 1:
//                    Console.WriteLine("Addition is : " + (a + b));
//                    break;
//                case 2:
//                    Console.WriteLine("Subraction is : " + (a - b));
//                    break;
//                case 3:
//                    Console.WriteLine("Multiplication : " + (a * b));
//                    break;
//                case 4:
//                    Console.WriteLine("Division :" + (a / b));
//                    break;
//                default:
//                    Console.WriteLine("Enter a valid number");
//                    break;
//            }
//        }
//    }
//}
