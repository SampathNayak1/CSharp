using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Student
    {
        protected Student(int sid)
        {
            Console.WriteLine("Student Constructor called : " + sid);
        }
    }
    class CollegeStudent : Student
    {
       internal CollegeStudent(int sid) : base(sid)
        {
            Console.WriteLine("COllage Student called : " + sid);
        } 
    }
    internal class ProtectedAM_PassingParametersUsing_BaseKeyword
    {
        static void Main(string[] args)
        {
            //Student student = new Student(1);

            CollegeStudent clg =new CollegeStudent(1);
            

        }
    }
}
