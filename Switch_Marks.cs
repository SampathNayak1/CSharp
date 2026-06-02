//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Switch_Marks
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("ENTER M1 MARKS");
//            int m1 = int.Parse(Console.ReadLine());
//            Console.WriteLine("ENTER M2 MARKS");
//            int m2 = int.Parse(Console.ReadLine());
//            Console.WriteLine("ENTER M3 MARKS");
//            int m3 = int.Parse(Console.ReadLine());
//            Console.WriteLine("ENTER M4 MARKS");
//            int m4 = int.Parse(Console.ReadLine());
//            Console.WriteLine("ENTER M5 MARKS");
//            int m5 = int.Parse(Console.ReadLine());
//            Console.WriteLine("ENTER M6 MARKS");
//            int m6 = int.Parse(Console.ReadLine());
//            int total = m1 + m2 + m3 + m4 + m5 + m6;
//            int avg = total / 6;
//            double percentage = (double)total / 600 * 100;

//            if (m1 >= 35 && m2 >= 35 && m3 >= 35 && m4 >= 35 && m5 >= 35 && m6 >= 35)
//            {
//                Console.WriteLine(" your pass ");
//                int gradeRange = (int)percentage / 10;

//                switch (gradeRange)
//                {
//                    case 10:
//                    case 9:
//                        Console.WriteLine("Your grade is A1");
//                        break;

//                    case 8:
//                        Console.WriteLine("Your grade is A2");
//                        break;

//                    case 7:
//                        Console.WriteLine("Your grade is B1");
//                        break;

//                    case 6:
//                        Console.WriteLine("Your grade is B2");
//                        break;

//                    case 5:
//                        Console.WriteLine("Your grade is C1");
//                        break;

//                    case 4:
//                    case 3:
//                        Console.WriteLine("Your grade is C2");
//                        break;

//                    default:
//                        Console.WriteLine("Your grade is F");
//                        break;
//                }

//                Console.WriteLine("\nYour average marks are: " + avg);
//                Console.WriteLine("\nYour percentage is: " + percentage + "%");
//            }
//            else
//            {
//                Console.WriteLine("You are Failed");
//                Console.WriteLine("Your grade is F");
//            }
//        }


//    }
//}

