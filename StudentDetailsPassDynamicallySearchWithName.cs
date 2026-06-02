//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Student
//    {
//          int id;
//       public string name;
//        public Student(int id, string name)
//        {
//            this.id = id;
//            this.name = name;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Studnet Id is : " + id);
//            Console.WriteLine("Student Name is : " + name);
//        }

//    }
//    internal class StudentDetailsPassDynamicallySearchWithName
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter How many students want to enter");
//            int n = Convert.ToInt32(Console.ReadLine());

//            Student[] students = new Student[n];

//            for (int i = 0; i < students.Length; i++)
//            {
//                Console.WriteLine("Enter student details ");

//                Console.WriteLine("Enter student Id : ");
//                int id = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("Enter student name : ");
//                string name = Console.ReadLine();

//                students[i] = new Student(id, name);
//            }

//            Console.WriteLine("Student details are : ");
//            for (int i = 0; i < n; i++)
//            {
//                students[i].Display();
//            }
//            Console.WriteLine("Search with student name " );
//            string searchname =Console.ReadLine();
//            for(int i=0; i < n; i++)
//            {
//                if (students[i].name ==  searchname )
//                {
//                    students[i].Display(); 
//                }
//            }
//        }
//    }
//}
