//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Inheritance
//    {
//        class Branch
//        {
//            int Bid;
//            String BName;
//            string Baddress;
//            public Branch(int Bid, string BName, string Badderess)
//            {
//                this.Bid = Bid;
//                this.BName = BName;
//                this.Baddress = Badderess;
//            }
//            public void BranchDisplay()
//            {
//                Console.WriteLine("Branch id : " + Bid);
//                Console.WriteLine("Branch Name is : " + BName);
//                Console.WriteLine("Branch Address : " + Baddress);
//            }
//        }
//        class Student : Branch
//        {
//            int Sid;
//            string Sname;
//            string SCollege;
//            public Student(int Sid, string Sname, string SCollege) : base(111, "AAA", "Ameerpet")
//            {
//                this.Sid = Sid;
//                this.Sname = Sname;
//                this.SCollege = SCollege;
//            }
//            public void StudentDisplay()
//            {
//                Console.WriteLine("Student id is : " + Sid);
//                Console.WriteLine("Student Name is : " + Sname);
//                Console.WriteLine("College : " + SCollege);
//            }
//        }
//        static void Main(string[] args)
//        {
//            Student st = new Student(1, "Sam", "IIIT-A");
//            st.StudentDisplay();

//        }
//    }
//}
