//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_115_Constructor_Student_Marks
//    {
//        static void Main(string[] args)
//        {
//            Student st1=new Student(1,"rama");
//            st1.CalResult(40, 50, 60);
//            st1.Display();
//        }
//    }
//    class Student
//    {
//        ulong sid;
//        string sname;
//        double totMarks;
//        double avgmarks;
//        string result;
//        internal Student(ulong stid,string stname)
//        {
//            sid = stid;
//            sname = stname;
//        }
//        internal void CalResult(double m1,double m2,double m3)
//        {
//              totMarks= m1 + m2 + m3;
//              avgmarks = totMarks / 3;
//            if(avgmarks >= 50)
//            {
//                result = "Passs";
//            }
//            else
//            {
//                result = "Fail";
//            }
//        }
//        internal void Display()
//        {
//            Console.WriteLine("Student id is : "+sid);
//            Console.WriteLine("Student name is : " + sname);
//            Console.WriteLine("Student Total marks is : " + totMarks);
//            Console.WriteLine("Student average mark is : " + avgmarks);
//            Console.WriteLine("Student result is : " + result);

//        }
//    }

//}
