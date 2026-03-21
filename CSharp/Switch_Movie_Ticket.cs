//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Switch_Movie_Ticket
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Select movie type: ");
//            Console.WriteLine("1-Regular") ;
//            Console.WriteLine("2-3D");
//            Console.WriteLine("3-IMAX");
//            int movieChoice = int.Parse(Console.ReadLine());

//            Console.WriteLine("Select Age catagory:  ");
//            Console.WriteLine("1-Child");
//            Console.WriteLine("2-Adult");
//            Console.WriteLine("3-Senior");
//            int ageChoice=int.Parse(Console.ReadLine());
//            double price = 0;
//            switch (movieChoice)
//            {
//                case 1:
//                    price = 200;
//                    break;
//                case 2:
//                    price = 300;
//                    break;
//                case 3:
//                    price = 400;
//                    break;
//                default:
//                    Console.WriteLine("Invalid Ticket!");
//                    break;
//            }

//            switch (ageChoice)
//            {
//                case 1:
//                    price = price * 0.8;
//                    break; 
//                case 2:
//                    price = price * 0.7;
//                    break;
//                case 3:
//                    price = price * 0.6;
//                    break;
//                default:
//                    Console.WriteLine("Invalid Age!");
//                    break;
//            }
//            Console.WriteLine("Final Tikcet Price is : " + price);
//        }
//    }
//}
