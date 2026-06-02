//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Student
//    {
//        public int Sid;
//        public string SName;
//        public Student(int sid,string sname)
//        {
//            Sid = sid;  
//            SName=sname;
//        }
//        public Student(Student Sobj)
//        {
//            Sid=Sobj.Sid;
//            SName = Sobj.SName;
//        }
//        public void StudentDisplay()
//        {
//            Console.WriteLine("Student id is : "+Sid);
//            Console.WriteLine("Student Name is : " + SName);
//        } 
//    }
//    internal class CopyConstructtor
//    {
//        static void Main(string[] args)
//        {
//            Student st = new Student(1, "Rama");
//            st.StudentDisplay();
//            Student obj = new Student(st);
//            obj.StudentDisplay();
//        }
//    }
//}
