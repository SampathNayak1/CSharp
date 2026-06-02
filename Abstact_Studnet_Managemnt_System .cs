//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    abstract class Person
//    {
//        public string Name;
//        public int Age {  get; set; }

//         public Person(String Name, int Age)
//        {
//            this.Name = Name;
//            this.Age = Age;
//            Console.WriteLine("Person Class Constructor");
//        }
//        public void DisplayInfo()
//        {
//            Console.WriteLine( "Student Name is : "+Name);
//            Console.WriteLine("Student Age is : " + Age);
//        }
//        abstract public void Roll (string sub);
//    }
//    class Student : Person
//    {
//        public int Rollno ;
//        public Student(int Rollno):base("Sam",26)
//        {
//            this.Rollno = Rollno;
//        }

//        public override void Roll(string sub)
//        {
//            Console.WriteLine("Subject is  " +sub );    
//        }
//    }
//    class Teacher : Person
//    {
//       public string Subject;
//      public Teacher(string subject) : base("Ravi",27)
//        {
//            this.Subject = subject;
//        }
            
//        public override void Roll(string sub)
//        {
//         Console.WriteLine("Teacher Role is To Tech "+sub +" Subject");    
//        }
//    } 


//    internal class Abstact_Studnet_Managemnt_System
//    {
      
//        static void Main()
//        {
//            Person t=new Student(1);
//            t.DisplayInfo();
//            t.Roll(".Net");

//            t  = new Teacher("CSharp");
//            t.DisplayInfo();   
//            t.Roll( ".Net");  
//}       }
//}
