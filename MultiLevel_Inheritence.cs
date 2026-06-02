//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class MultiLevel_Inheritence
//    {
//        static void Main(string[] args)
//        {
//            Employee emp1 = new Employee(1001,"Rama",200000);
//            emp1.DisplayEmpInfo();
//        }
//    }

//    class Department
//    {
//        readonly ulong deptno;
//        readonly string deptname;
//        internal Department(ulong deptno,string deptname)
//        {
//            this.deptno = deptno;
//            this.deptname = deptname;
//        }
//        internal void DisplayDeptInfo()
//        {
//            Console.WriteLine("Dept No is : "+deptno);
//            Console.WriteLine("Dept Name is : " + deptname);
//        }
//    }

//    class Branch : Department
//    {
//        readonly ulong branchno;
//        readonly string branchloc;

//        internal Branch(ulong branchno, string branchloc):base(101,"IT") 
//        {
//            this.branchno = branchno;
//            this.branchloc = branchloc;
//        }
      
//        internal void DisplayBranchInfo()
//        {
//            Console.WriteLine("Branch No is : "+branchno);
//            Console.WriteLine("Branch location is : " + branchloc);
//            base.DisplayDeptInfo();
//        }
//    }
//    class Employee : Branch
//    {
//        readonly ulong eno;
//        readonly string ename;
//        double esal;
//        internal Employee(ulong eno,string ename,double esal):base(1,"Hyderabad")
//        {
//            this.eno = eno;
//            this.ename = ename;
//            this.esal = esal;
//        }
//        internal void DisplayEmpInfo()
//        {
//            Console.WriteLine("Employee no is : "+eno);
//            Console.WriteLine("EMployee Name is : " + ename);
//            Console.WriteLine("Employee sal is : " + esal);
//            base.DisplayBranchInfo();
//        }
//    }
    
//}
