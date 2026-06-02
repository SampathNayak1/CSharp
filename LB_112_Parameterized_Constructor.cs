//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class LB_122_Parameterized_Constructor
//    {
//        static void Main(string[] args)
//        {
//           Employee emp1=new Employee(1,"Rama",1000);
//            emp1.Display();
//            Employee emp2 = new Employee(2, "sitha", 2000);
//            emp2.Display();
//        }
//    }
//    class Employee
//    {
//        ulong empid;
//        string empname;
//        decimal empsal;
//        internal Employee(ulong eid,string ename,decimal esal)
//        {
//            empid = eid;
//            empname = ename;
//            empsal = esal;
//        }
//        internal void Display()
//        {
//            Console.WriteLine("Employee number is : " + empid);
//            Console.WriteLine("Employee name is : " + empname);
//            Console.WriteLine("Employee salary is : " + empsal);
//        }
//    }
//}
