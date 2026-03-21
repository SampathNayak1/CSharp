//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LP21
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter a number");
//            int num = int.Parse(Console.ReadLine());
//            int quot;
//            string rem = " ";
//            while (num >= 1)
//            {
//                quot = num / 2;
//                Console.WriteLine(quot);
//                rem += (num%2).ToString();
//                Console.WriteLine(rem);
//                num= quot; 
//            }
//            string bin = "";
//            for(int i=rem.Length-1; i >= 0; i--)
//            {
//                bin = bin + rem[i];
//            }
//            Console.WriteLine("Binary Format is  :  "+bin);
//        }
//    }
//}
