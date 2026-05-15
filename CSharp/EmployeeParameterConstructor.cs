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
//        double Esal;
//        public Employee()
//        {
//            Eid = 101;
//            Ename = "Rama";
//            Esal = 50000;
//        }
//        public Employee(int eid, string ename, double esal)
//        {
//            Eid = eid;
//            Ename = ename;
//            Esal = esal;
//        }

//        public void DisplayEmp()
//        {
//            Console.WriteLine("Employee Id : " +Eid) ;
//            Console.WriteLine("Employee name : " + Ename);
//            Console.WriteLine("EMployee Salary : "+Esal );
//        }
//    }
//    internal class EmployeeParameterConstructor
//    {
//        static void Main(string[] args)
//        {

//            Employee emp=new Employee();
//            emp.DisplayEmp();  
//            Employee  emp1=new Employee(102,"Sitha",60000);
//            emp1.DisplayEmp();

//        }
//    }
//}
