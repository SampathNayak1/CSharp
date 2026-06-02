//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class BankAccount
//    {
//        private double Accountno;
//        private double Balance;
//        static string Bankname = "SBI";

//        public BankAccount(double Accountno, double Balance)
//        {
//            this.Accountno = Accountno;
//            this.Balance = Balance;

//        }
//        public void DisplayBank()
//        {
//            Console.WriteLine("Bank Name is : " + Bankname);
//            Console.WriteLine($"Account Number is {Accountno}");
//            Console.WriteLine($"Available Balance is {Balance}");
//        }
//        public void Deposite(double Amount)
//        {
//            Balance += Amount;
//            Console.WriteLine($"After Deposite {Amount} Available Balance is : {Balance}");
//        }
//        public void Withdraw(double Amount)
//        {
//            if (Amount <= Balance)
//            {
//                Balance -= Amount;
//                Console.WriteLine($"After WithDraw {Amount} Aw" +
//                    $"vailable Balace is : {Balance}");
//            }
//        }
//        internal class BankaccountExample
//        {
//            static void Main(string[] args)
//            {
//                BankAccount ba = new BankAccount(9876543231, 50000);
//                ba.DisplayBank();
//                ba.Deposite(20000);
//                ba.Withdraw(10000);
//            }
//        }
//    }
//}
