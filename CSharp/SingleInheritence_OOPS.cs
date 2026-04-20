using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class SingleInheritence_OOPS
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(111,"Rama",10000);
            emp.DisplayEmpInfo(); 
        }
    }
    class Department
    {
        readonly ulong deptno;
        readonly string deptname;
        internal Department(ulong deptno,string deptname)
        {
           this.deptno = deptno;
           this.deptname=deptname; 
        } 
        internal void DisplayDeptInfo()
        {
            Console.WriteLine("Dept No is : "+deptno);
            Console.WriteLine("Dept Name is : " + deptname);
        } 
    }
    class Employee : Department
    {
        readonly ulong empno;
        readonly string empname;
        double empsal;
        internal Employee(ulong empno,string empname,double empsal):base(10,"IT")
        {
            this.empno = empno;
            this.empname= empname;
            this.empsal = empsal;
        }
        internal void DisplayEmpInfo()
        {
            Console.WriteLine("Emp No is : "+empno);
            Console.WriteLine("Emp name is : "+empname);
            Console.WriteLine("Emp sal is : "+empsal );
            base.DisplayDeptInfo();
        }
    } 
}
