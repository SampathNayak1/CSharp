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
//        string Name;
//        static string College;
//        public Student(int Sid,string Name)
//        {
//            this.Sid = Sid;
//            this.Name = Name;
//        }
//        static Student()
//        {
//            College = "IIITA";
//        }
//        public static void CollegeDispaly()
//        {
//            Console.WriteLine("College name is : " + College);
//        }
//        public void Dispay()
//        {
//            Console.WriteLine("Stundent id is " + Sid);
//            Console.WriteLine("Student Name is " + Name);
//        }
             

//    }

//    internal class StaticConstuctor
//    {
//        static void Main(string[] args)
//        {
//            Student st1=new Student(1,"Rama");
//            st1.Dispay();
//            Student st2 = new Student(2,"Sitha");
//            st2.Dispay();
//            Student.CollegeDispaly();

//        }
//    }
//}
