//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class If_Else_If
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
//                if (percentage > 90)
//                {
//                    Console.WriteLine(" your grade is A1 ");
//                }
//                else if (percentage > 80 && percentage < 90)
//                {
//                    Console.WriteLine(" your grade is A2 ");
//                }
//                else if (percentage > 70 && percentage < 80)
//                {
//                    Console.WriteLine(" your grade is B1 ");
//                }
//                else if (percentage > 60 && percentage < 70)
//                {
//                    Console.WriteLine(" your grade is B2 ");
//                }
//                else if (percentage > 50 && percentage < 60)
//                {
//                    Console.WriteLine(" your grade is C1 ");
//                }
//                else if (percentage > 35 && percentage < 50)
//                {
//                    Console.WriteLine(" your grade is C2 ");
//                }
//                Console.WriteLine("\n your avgmarks are: " + avg);
//                Console.WriteLine(" \n your percentage is: " + percentage + "%");

//            }
//            else
//            {
//                Console.WriteLine("your failed");
//                Console.WriteLine(" your grade is F ");
//            }
//        }
//    }
//}
