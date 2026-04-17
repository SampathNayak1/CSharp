//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_113_Parameterized_Constructor
//    {
//        static void Main(string[] args)
//        {
//            Student st1=new Student(1, "Rama", "HYD");
//            st1.Display();
//            Student st2 = new Student(2, "Sitha", "Banglore");
//            st2.Display();

//        }
//    }
//    class Student
//    {
//        ulong sid;
//        string sname;
//        string sloc;
        
//        internal Student(ulong stid,string stname,string stloc)
//        {
//            sid=stid;
//            sname=stname;
//            sloc=stloc;
//        }
//        internal void Display()
//        {
//            Console.WriteLine("Student id is : " + sid);
//            Console.WriteLine("Student name is : " + sname);
//            Console.WriteLine("Student Location is : " + sloc);
//        }
//    }
//}
