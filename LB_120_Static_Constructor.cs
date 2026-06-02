//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_120_Static_Constructor
//    {
//        static void Main(string[] args)
//        {
//            Employee emp1 = new Employee(111,"Rama",20000);
//            emp1.Dispaly();
//            Employee emp2 = new Employee(222, "Sitha", 30000);
//            emp2.Dispaly();
//            Employee.Display();
//        }
//    }
//    class Employee
//    {
//        ulong eno;
//        string ename;
//        double esal;
//        static string compname;
//        static string comploc;
//        static string compphno;

//        internal Employee(ulong empno, string empname, double empsal)
//        {
//            eno = empno;
//            ename = empname;
//            esal = empsal;
//        }
//        static Employee()
//        {
//            compname = "Wipro";
//            comploc = "Hyd";
//            compphno = "987654321";
//        }
//        internal void Dispaly()
//        {
//            Console.WriteLine("Employee no is : " + eno);
//            Console.WriteLine("Employee name is : " + ename);
//            Console.WriteLine("Employee salary is : " + esal);
//        } 
//        internal static void Display()
//        {
//            Console.WriteLine("Company name is : "+compname);
//            Console.WriteLine("Compnay location is : " + comploc);
//            Console.WriteLine("Conpmany Phone no is :" + compphno);
//        }
//    }
//}
