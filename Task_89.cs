//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Task_89
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Customer name : ");
//            string Cname=Console.ReadLine();

//            Console.WriteLine("Enter Customer type : ");
//            Console.WriteLine("Press one for Industry.");
//            Console.WriteLine("Press two for Residential.");
//            Console.WriteLine("Press three for Residential.");
//            int Ctype =int.Parse(Console.ReadLine());

//            Console.WriteLine("Consumed unites are : ");
//            int Cunites=int.Parse(Console.ReadLine());
//            int bill = 0;

//            switch (Ctype)
//            {
//                case 1:
//                    bill = 8 * Cunites;
//                    Console.WriteLine(Cname + " total bill is " + bill);
//                    break;
//                case 2:
//                    bill = 6 * Cunites;
//                    Console.WriteLine(Cname + " total bill is " + bill);
//                    break;
//                case 3:
//                    bill = 2 * Cunites;
//                    Console.WriteLine(Cname + " total bill is " + bill);
//                    break;
//                default:
//                    Console.WriteLine("Enter customer type.");
//                    break;
//            }
            

//        }
//    }
//}
