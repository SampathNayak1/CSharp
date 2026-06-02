//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_121_Constructor
//    {
//        static void Main(string[] args)
//        {
//            Student st = new Student(111, "Sam", "HYD");
//            st.CalculateResult(50, 60, 70);
//            st.StudentInfoDispaly();
//            Student.ColgInfoDisplay();
//        }
//    }
//    class Student
//    {
//        ulong sid;
//        string sname;
//        string sloc;
//        double totmarks;
//        double Avgmarks;
//        string result;
//        static string colgname = "IIIT-Allahabad";
//        static string colgphno = "9876543210";
//        static string colgloc = "UP";

//        internal Student(ulong stid, string stname, string stloc)
//        {
//            sid = stid;
//            sname = stname;
//            sloc = stloc;
//        }
//        internal void CalculateResult(double m1, double m2, double m3)
//        {
//            totmarks = m1 + m2 + m3;
//            Avgmarks = totmarks / 3;
//            if (Avgmarks < 50)
//            {
//                result = "Pass";
//            }
//            else
//            {
//                result = "Fail";
//            }
//        }
//        internal void StudentInfoDispaly()
//        {
//            Console.WriteLine("Student no is : " + sid);
//            Console.WriteLine("Student name is : " + sname);
//            Console.WriteLine("Student location : " + sloc);
//        }
//        internal static void ColgInfoDisplay()
//        {
//            Console.WriteLine("Collage name is : " + colgname);
//            Console.WriteLine("College location  is : " + colgloc);
//            Console.WriteLine("College Phone num is : " + colgphno);
//        }
//    }
//}
