//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class EmployeeExample
//    {
//        class Employee
//        {
//            int EmpId;
//            string Name;
//            double Sal;
//            static string company;
//            public Employee(int EmpId,string Name,double Sal) 
//            {
//                this.EmpId = EmpId;
//                this.Name = Name;
//                this.Sal = Sal;
//            }
//            static Employee()
//            {
//                company = "Infosys";
//            }
//            public void Dispay()
//            {
//                double hike = 0;
//                    hike= (0.10 * Sal)+Sal ;
//                Console.WriteLine("Empolyee id is : " + EmpId);
//                Console.WriteLine("EMployee Name is : " + Name);
//                Console.WriteLine("Employee Salary is : " + Sal);
//                Console.WriteLine("Employee Hike with salary is " + hike);
//            }
//            public static void DisplayCompany()
//            {
//                Console.WriteLine("Company name is : " + company);

//            }
//        }
//        static void Main(string[] args)
//        {
//            Employee emp = new Employee(1,"Rama",50000);
//            emp.Dispay();
//            Employee.DisplayCompany();
//        }
//    }
//}
