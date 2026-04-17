//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_114_Constructor_Parameterized
//    {
//        static void Main(string[] args)
//        {
//          Employee emp1=new Employee(1, "Rama", 50000, "HR");
//            emp1.Display();
//            double increment1 = emp1.Hike(50000 );
//            Console.WriteLine("Increment salary is : " +increment1 );

//            Employee emp2 = new Employee(2, "Sitha",60000,"IT");
//                emp2.Display();
//                double increment2= emp2.Hike(60000);
//            Console.WriteLine("Increment salary is : "+increment2);
//        }
//    }
//     class Employee
//    {
//        ulong eid;
//        string ename;
//        double esal;
//        string edesignation;

//        internal Employee(ulong empid, string empname, double empsal, string empdesignation)
//        {
//            eid = empid;
//            ename = empname;
//            esal = empsal;
//            edesignation = empdesignation;
//        }
//        internal double Hike(double empsal)
//        {
//            double hike = esal * 0.10;
//            hike=hike+esal;

//            return hike;

//        }
//        internal void Display()
//        {
//            Console.WriteLine("Employee number is : "+ eid );
//            Console.WriteLine("Employee Name is : " + ename);
//            Console.WriteLine("Employee Designation is : " + edesignation);
//            Console.WriteLine("Employee Salary is : " + esal);
//        }
//    }
    
//}
