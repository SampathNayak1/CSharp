//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Student
//    {
//        int Sid;
//        string Sname;
//        int Sage;
        
//        public Student()
//        {
//            Sid = 1;
//            Sname = "ABC";

//        }
//        public Student(int sid)
//        {
//            Sid = sid;
//            Sname = "Not Provider";

//        }
//        public Student( string sname, int sage)
//        {
//            Sname = sname;
//            Sage = sage;
//        }
//        public Student(int sid, string sname)
//        {
//            Sid = sid;
//            Sname=sname;
//        }
//        public void DisplayDetails()
//        {
//            Console.WriteLine("Student Id is : "+Sid );
//            Console.WriteLine("Student Name is : " + Sname);
//            Console.WriteLine("Stuednt Age is : "+Sage);
//        }
//    }
//    internal class ConstructorOverload
//    {
//        static void Main(string[] args)
//        {
//            Student std1 = new Student( );
//            std1.DisplayDetails();
//            Console.WriteLine("----------");

//            Student std2 =new Student(1 );
//            std2.DisplayDetails();
//            Console.WriteLine("----------");

//            Student std3 =new Student(2,"Sam");
//            std3.DisplayDetails();
//            Console.WriteLine("----------");

//            Student std4 = new Student("Raghu",20);
//            std4.DisplayDetails();
//        }
//    }
//}
