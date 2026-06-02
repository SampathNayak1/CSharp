//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Exception_ArgumentOutOfRange
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                program obj = new program();
//                obj.SetAge(12);
//                //obj.SetAge(-1);
//            }
//            catch(ArgumentOutOfRangeException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        } 
//    }
//    internal class program
//    {
//        public void SetAge(int age)
//        {
//            if(age> 0 || 120 > age)
//            {
//                throw new ArgumentOutOfRangeException(nameof(age));
//            }
//            Console.WriteLine(age);

//        }
//    }
//}
