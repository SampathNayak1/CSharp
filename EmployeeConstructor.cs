//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Employee
//    {
//        int Eid;
//        string Ename;
//        int Esal;
//        double EsalHike;
//        static string company = "Wipro ";

//        public Employee()
//        {
//            Eid = 1;
//            Ename = "rama";
//            Esal = 25000;

//        }

//        public void EmpDisplay()
//        {
//            Console.WriteLine("Employee id " + Eid);
//            Console.WriteLine("Employee name " + Ename);
//            Console.WriteLine("Company name is " + company);
//            Console.WriteLine("Employee sal " + Esal);

//        }
//        public void EmpHike()
//        {
//            double Newsal;
//            EsalHike = 0.20 * Esal;
//            Console.WriteLine("Employee Hike is " + EsalHike);

//            Newsal = Esal + EsalHike;
//            Console.WriteLine("Employee New Sal " + Newsal);
//        }
//    }

//    internal class EmployeeConstructor
//    {
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee();
//            emp.EmpDisplay();
//            emp.EmpHike();
//        }
//    }
//}
