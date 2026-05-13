//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{

//    class Student
//    {

//        int Sid, Sage;
//        string Sname;
//        //static string College;
//        static string College = "ABC College ";

//        public void StudnetDetail()
//        {

//            Console.WriteLine("Enter Student Id : ");
//            Sid = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Student Name : ");
//            Sname = Console.ReadLine();
//            Console.WriteLine("Enter Student Age : ");
//            Sage = Convert.ToInt32(Console.ReadLine());
//            //Console.WriteLine("Enter Student Collage : ");
//            //College = Console.ReadLine();
//        }
//        public void Dispay()
//        {
//            Console.WriteLine("Student Details are : ");
//            Console.WriteLine("Student Id is : " + Sid);
//            Console.WriteLine("Student Name is : " + Sname);
//            Console.WriteLine("Student Age is : " + Sage);
//            Console.WriteLine("Student Collage name is : " + College);
//        }

//        internal class StudeantDetails
//        {
//            static void Main(string[] args)
//            {
//                Console.WriteLine("Enter the No of Student Details you wante to enter");
//                int n = Convert.ToInt32(Console.ReadLine());
//                Student[] students = new Student[n];
//                for (int i = 0; i < n; i++)
//                {
//                    students[i] = new Student();
//                    students[i].StudnetDetail();
//                }

//                for (int i = 0; i < n; i++)
//                {
//                    students[i].Dispay();
//                }
//                Console.ReadLine();
//            }


//        }
//    }
//}



