//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Encapsultion_PatientRecord
//    {
//        class Hospital
//        {
//            private string Name;
//            private int Age;
//            private String discription;

//            public string Discription
//            {
//                get { return discription; }
//                set { discription = value; }
//            }
//            public Hospital (string name, int age, string discription)
//            {
//                Name = name;
//                Age = age;
//                this.discription = discription;
//            }

//            public void Display()
//            {
//                Console.WriteLine("Name : " + Name);
//                Console.WriteLine("Age : "+Age);
//                Console.WriteLine("Decription : "+ Discription);
//            }

//        }
//        static void Main(string[] args)
//        {
//            Hospital hs=new Hospital("Ram",22,"Fever");
//            hs.Display();
//        }
//    }
//}
