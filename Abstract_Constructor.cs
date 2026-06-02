//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
   

//    abstract class Person
//    {
//        protected string name;
//        private int age;
//        public Person(string name, int age)
//        {
//            this.name = name;
//            this.age = age;
//            Console.WriteLine("Person Constructor Called");
//        }
//        public void DisplayInfo()
//        {
//            Console.WriteLine($"Name : {name}\nAge : {age}");
//        }
//        abstract public void Roll();
//        abstract public void TeacherSub();
//    }
//    class Student : Person
//    {
//        private int rollno;
//        public Student(int rollno, string name, int age) : base(name, age)
//        {
//            this.rollno = rollno;
//        }
//        public void StudentRoll()
//        {
//            Console.WriteLine($"RollNo {rollno}");
//        }
//        public override void Roll()
//        {
//            Console.WriteLine("This is Override Method");
//        }
//        public override void TeacherSub()
//        {
//             Console.WriteLine("I am a Teacher");   
//        }
//    }
   
  

//    internal class Abstract_Constructor
//    {
         

//        static void Main(string[] args)
//        {
//            Student st=new Student(101,"Ram",27);
//            st.DisplayInfo();
//            st.StudentRoll();
//            st.Roll();
//            st.TeacherSub();
//        } 
//    }
//}
