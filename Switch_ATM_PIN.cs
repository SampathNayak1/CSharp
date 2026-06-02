//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    internal class Switch_ATM_PIN
//    {
//        static void Main(string[] args)
//        {
//            int pinnum = 1234;
//            int balance = 10000;
//            Console.WriteLine("Enter your option : ");
//            Console.WriteLine("1-Deposite, 2-Withdraw, 3-Balance, 4-Mini Statement");
//            int optnum = int.Parse(Console.ReadLine());
//            switch (optnum)
//            {
//                case 1:
//                    Console.WriteLine("Enter your account number : ");
//                    int accountnum = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter valid account number : ");
//                    int confirmAccount = int.Parse(Console.ReadLine());
//                    if (accountnum == confirmAccount)
//                    {
//                        Console.WriteLine("Enter your deposite amount :");
//                        int amount = int.Parse(Console.ReadLine());
//                        balance = balance + amount;
//                        Console.WriteLine(amount + " Deposited and avalable baclence is : " + balance);
//                    }
//                    break;
//                case 2:
//                    Console.WriteLine("Enter your withdraw amount : ");
//                    int wdamount = int.Parse(Console.ReadLine());
//                    Console.WriteLine("Enter your pin number : ");
//                    int pin = int.Parse(Console.ReadLine());
//                    if (pinnum == pin)
//                    {
//                        if (wdamount < balance)
//                        {
//                            balance = balance - wdamount;
//                            Console.WriteLine(wdamount + " amount is withdraw and available balence is : " + balance);
//                        }
//                        else
//                        {
//                            Console.WriteLine("You do not have sufficinet balence.");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("You enterd wrong pin. please try after some time. ");
//                    }

//                    break;
//                case 3:
//                    Console.WriteLine("Enter your pin : ");
//                    int pin1 = int.Parse(Console.ReadLine());
//                    if (pinnum == pin1)
//                    {
//                        Console.WriteLine("Current avialable balence is : " + balance);
//                    }
//                    else
//                    {
//                        Console.WriteLine("you entered wrong pin. Please try after some time. ");
//                    }

//                    break;
//                case 4:
//                    Console.WriteLine("Enter pin number : ");
//                    int pin2 = int.Parse(Console.ReadLine());
//                    if (pinnum == pin2)
//                    {
//                        Console.WriteLine("Current avialable balence is : " + balance);
//                        Console.WriteLine("Sorry!, for this service please visit near branch");

//                    }
//                    else
//                    {
//                        Console.WriteLine("You enterd wrong pin. Please try after some time.");
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Please visit nearest bank.");
//                    break;

//            }
//        }
//    }
//}
