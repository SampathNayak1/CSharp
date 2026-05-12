using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Stundent
    {
        static string collegename = "Narayana Junior College";
        int Sid;
        string Sname;
        byte Sage;

        public void StudentDetails(int Sid, string Sname, byte Sage)
        {
            this.Sid = Sid;
            this.Sname = Sname;
            this.Sage = Sage;
        }

        public void Display()
        {
            Console.WriteLine("Student Id is : " + Sid);
            Console.WriteLine("Student Name is : " + Sname);
            Console.WriteLine("Student Age is :  " + Sage);
            Console.WriteLine("Stundent Collage is : " + collegename);
        }
    }
    internal class StudeantDetails
    {
        static void Main(string[] args)
        {
            Stundent std1= new Stundent();
            std1.StudentDetails(1,"Ram",20);
            std1.Display(); 

            std1.StudentDetails(2, "Sitha", 21);
            std1.Display();

            std1.StudentDetails(3, "Lakman", 22);
            std1.Display();

            std1.StudentDetails(4, "Hanuma", 23);
            std1.Display();

            std1.StudentDetails(5, "Karna", 24);
            std1.Display();
        }
    }
   
}
