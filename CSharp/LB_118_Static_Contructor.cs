//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_118_Static_Contructor
//    {
//        static void Main(string[] args)
//        {
//            Student st=new Student(111,"Sam","HYD");
//            st.Dispaly();
//        }
//    }
//    class Student
//    {
//        ulong sid;
//        string sname;
//        string sloc;
//        static string clgname;

//        static Student()
//        {
//            clgname = "IIIT-Allahabad";
//        }
//        internal Student(ulong stid,string stname,string stloc)
//        {
//            sid=stid;
//            sname=stname;
//            sloc = stloc;
//        }
//        internal void Dispaly() 
//        {
//            Console.WriteLine("Student no is : " + sid);
//            Console.WriteLine("Student name is : "+sname);
//            Console.WriteLine("Student Location is : " + sloc);
//            Console.WriteLine("Student Collage name is : " + clgname); 
//        }
//    }
//}
