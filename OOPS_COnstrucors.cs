//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class OOPS_COnstrucors
//    {
//       static void Main(string[] args)
//        {
//            Employee emp1 = new Employee(111,"Rama",10000);
//            emp1.Display();
//            Console.ReadLine();
//        } 
//    }
//    class Employee
//    {
//        ulong eno;
//        string ename;
//        double esal;
//        static string ecompany;
        
//        static Employee()
//        {
//            ecompany = "Wipro";
//        }
//        internal Employee(ulong empno, string empname, double empsal)
//        {
//            eno = empno;
//            ename = empname;
//            esal = empsal;
//        }

//        internal void Display()
//        {
//            Console.WriteLine("Employee number is : " + eno);
//            Console.WriteLine("Employee Name is : " + ename);
//            Console.WriteLine("Employee salary is : " + esal);
//            Console.WriteLine("Company name is :" + ecompany);
//        }
//    }
//}
