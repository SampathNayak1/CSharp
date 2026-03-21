//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LP15_Febonacci_Series
//    {
//        static void Main(string[] args)
//        {
//            int a = 0, b = 1, c = 0;
//            int sum = 0, count = 0;

//            Console.Write("Enter ur range: ");
//            int n = int.Parse(Console.ReadLine());

//            Console.Write("Fibonacci Series: ");
//            while (a <= n)
//            {
//                Console.Write(a + " ");

//                sum += a;      // add current Fibonacci number to sum
//                count++;       // increment count of numbers

//                c = a + b;
//                a = b;
//                b = c;
//            }

//            Console.WriteLine("\nTotal Count: " + count);
//            Console.WriteLine("Sum of Fibonacci numbers: " + sum);

//            Console.ReadLine();
//        }
//    }
//}
