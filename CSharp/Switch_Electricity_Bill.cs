//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Switch_Electricity_Bill
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("<-------Electricity Bill------>");
//            Console.WriteLine("Enter Customer Name : ");
//            string name = Console.ReadLine();
//            Console.WriteLine("1-Industry");
//            Console.WriteLine("2-Residency");
//            Console.WriteLine("3-Agriculture");
//            int choose=int.Parse(Console.ReadLine());
//            Console.WriteLine("Enter number of units Consumed : ");
//            int units=int.Parse(Console.ReadLine()); 
//            int bill = 0;
//            switch (choose)
//            {
//                case 1:
//                    bill = 6 * units;
//                    Console.WriteLine("Industry consumed untes are : " + bill);
//                    break;
//                case 2:
//                    bill = 4 * units;
//                    Console.WriteLine("Residencial counsumed unites are : " + bill);
//                    break;
//                case 3:
//                    bill = 2 * units;
//                    Console.WriteLine("Agriculture consumed units are : " + bill);
//                    break;
//                default:
//                    Console.WriteLine("Enter your choice.");
//                    break;

//            }   

//        }
//    }
//}
