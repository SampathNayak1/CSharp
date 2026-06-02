//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_116_Employee_Constructor
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee(111,"Sam",1000, "sampath@gmail.com", 891981102);
//            emp.Display();
//        }
//    }
//    class Employee
//    {
//        ulong eno;
//        string ename;
//        byte eage;
//        double basicsal;
//        double hra;
//        double da;
//        double ta;
//        double grosssal;
//        ulong ephoneno;
//        string mail;
//        internal Employee(ulong empno, string empname, double empbasicsalary, string empemail, ulong empphoneno)
//        {
//            if (empno > 100 && empno < 1000)
//                eno = empno;
//            else
//                Console.WriteLine("Invalid employee number.");

//            ename = empname;
//            basicsal = empbasicsalary;

//            hra = empbasicsalary * 0.10;
//            da = empbasicsalary * 0.15;
//            ta = empbasicsalary * 0.10;
//            grosssal = empbasicsalary + hra + da + ta;

//            string ph = empphoneno.ToString(); 
//        }  
              

            
//            internal void Display()
//        {
//            Console.WriteLine("Employee No: " + eno);
//            Console.WriteLine("Employee Name: " + ename);
//            Console.WriteLine("Basic Salary: " + basicsal);
//            Console.WriteLine("HRA: " + hra);
//            Console.WriteLine("DA: " + da);
//            Console.WriteLine("TA: " + ta);
//            Console.WriteLine("Gross Salary: " + grosssal);
//            Console.WriteLine("Phone No: " + ephoneno);
//            Console.WriteLine("Email: " + mail);
//            Console.WriteLine("---------------------------");
         
//    }

//    }
//}
