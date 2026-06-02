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
//        string college;

//        public Student()
//        {
//            Sid = 1;
//            Name = "Ram";
//            college = "ABC";
//        }
//        public Student(int Sid, string Name, String college)
//        {
//            this.Sid = Sid;
//            this.Name = Name;
//            this.college = college;
//        }
//        public Student(int Sid, string Name)
//        {
//            this.Sid = Sid;
//            this.Name = Name;
//        }
//        public Student(string Name)
//        {
//            this.Name = Name;
//        }
        
//        public void Display()
//        {
//            Console.WriteLine("Student ID is : " + Sid);
//            Console.WriteLine("Student Name is : " + Name);
//            Console.WriteLine("Studnt College name is : " + college);
//        }
//    }
//    internal class ConstructorOverLoading
//    {
//        static void Main(string[] args)
//        {
//            Student student1 = new Student();
//            student1.Display();
//            Student student2 = new Student(101, "Sam", "FGH");
//            student2.Display();
//            Student student3 = new Student(102, "Ramesh", "JKL");
//            student3.Display();
//            Student student4 = new Student("Suresh");
//            student4.Display();


//        }

//    }
//}
