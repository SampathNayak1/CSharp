//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class BankAccount
//    {
//        private double balance;
//        private string pin;

//        public double Balance
//        {
//            get { return balance; }

//            set
//            {
//                if (balance >=  0) 
//                {
//                     balance = value;
//                }
                
//            }
//        }

//        public void Deposite(double Amount)
//        {
//            if (Amount > 0)
//            {
//                balance += Amount;

//            }

//        }
//        public void Withdraw(double Amount, string entredpin)
//        {

//            if (entredpin == pin && Amount <= Balance)
//            {
//                balance -= Amount;
//            }
//        }

//        public BankAccount(double initialBalance, string enteredPin)
//        {
//            Balance = initialBalance;
//            pin = enteredPin;
//        }

//    }
//    internal class EncapsulationEx
//    {
//        static void Main(string[] args)
//        {
//            BankAccount account = new BankAccount(-40000, "1234");

//            account.Deposite(10000);

//            //account.Withdraw(10000,"1111");

//            account.Withdraw(10000, "1234");
//            Console.WriteLine("Balance is : " + account.Balance);
//        }
//    }
//}
