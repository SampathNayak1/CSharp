//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Person
//    {
//       public int Age { get; set; } 
//       public string Name { get; set; }

//        public Person(int age, string name)
//        {
//            Age = age;
//            Name = name;
//        }
//        public Person(Person PreviousPerson)
//        {
//            Age = PreviousPerson.Age;
//            Name= PreviousPerson.Name;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Person Name : " + Name);
//            Console.WriteLine("Person Age : " + Age);
//        }
//    }
//    internal class CopyConstructorEx
//    {
//        static void Main(string[] args)
//        {
//            Person p1 = new Person(30, "sam");
//            Person p2 = new Person(28, "Rama");
//        }
//    }
//}
