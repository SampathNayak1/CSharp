//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Students
//    {
//        int Sid;
//        string Sname;
//        int Sfee;

//        public Students()
//        {
//            Sid = 1;
//            Sname = "Rama";
//            Sfee = 25000;
//        }

//        public Students(int sid,string sname, int sfee)
//        {
//            Sid= sid;
//            Sname= sname;
//            Sfee= sfee;
//        }


//        public void StuDisplay()
//        {
//            Console.WriteLine("Student id : " + Sid);
//            Console.WriteLine("Student Name : " + Sname);
//            Console.WriteLine("Student fee : " + Sfee);
//        }
//    }
//    internal class UserDefined_Constructor
//    {
//        static void Main(string[] args)
//        {
//            Students std = new Students( );
//            std.StuDisplay( );

//            Students student1 = new Students(202, "XXX", 25000);
//            student1.StuDisplay( );


//            //Console.WriteLine(student.Equals(true));
//            //Console.WriteLine(student.ToString());
//            //Console.WriteLine(student.GetHashCode());

//            //Console.WriteLine(student.GetType());

//        }
//    }
//}
