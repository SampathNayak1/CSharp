//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Employee
//    {
//        int empid, empsal;
//        string empname;
//        static string empcompany = "Wipro";
        
//        public void EmpDetails()
//        {
//            Console.WriteLine("Enter Employee Id : ");
//            empid = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter Employee Name : ");
//            empname = Console.ReadLine();
//            Console.WriteLine("Enter Employee Salary : ");
//            empsal=Convert.ToInt32(Console.ReadLine()); 
//        }

//        public void DisplayEmp()
//        {
//            Console.WriteLine("Employee Id is : " +empid);
//            Console.WriteLine("Employee Name is : " + empname);
//            Console.WriteLine("Employee Salary is : " + empsal);
//            Console.WriteLine("Employee Comopany name is : "+empcompany);
//        }
//    }
//    internal class EmployeeDetailsUsingClass
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number of employee you want to enter");
//            int n = Convert.ToInt32(Console.ReadLine());
//            Employee[] emp = new Employee[n];
//            for(int i = 0; i < n; i++)
//            {
//                emp[i] = new Employee();
//                emp[i].EmpDetails();
//            }
//            for (int i=0;i<n;i++)
//            {
//                emp[i].DisplayEmp();
//            }
//        }
//    }
//}
