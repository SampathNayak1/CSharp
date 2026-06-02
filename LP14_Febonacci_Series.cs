//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LP14_Febonacci_Series
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number : ");
//            int number=int.Parse(Console.ReadLine());

//            int a = 0; 
//            int b = 1; 
//            int c = 0;
//            int sum = 0;
//            int count = 0;
//            while (a <= number)
//            {
//                sum += a;
//                count++;
//                Console.WriteLine(a);
//                c = a + b;
//                a = b;
//                b = c;      
//            }
//            Console.WriteLine("Sum of Febonacci " + sum);
//            Console.WriteLine( "Counnt of Febocci " + count);
//        }
//    }
//}
