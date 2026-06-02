using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    interface IpaymentGateway
    {
        void PaymentProcess();

    }
    class Paypal : IpaymentGateway
    {
         public void PaymentProcess()
        {
            Console.WriteLine("Paypal Payment");
        }
    }
    class UPIgateway : IpaymentGateway
    {
        public void PaymentProcess()
        {
            Console.WriteLine("UPI Paymant ");
        }
    }

    class Credit : IpaymentGateway
    {
        public void PaymentProcess() 
        {
            Console.WriteLine("This is Credit card Payment gateway");
        }
    }
    internal class Inheritance_MultipleEx
    {
        static void Main(string[] args)
        {

            IpaymentGateway  gt=new Paypal();
            gt.PaymentProcess();
            IpaymentGateway gt1= new UPIgateway();
            gt1.PaymentProcess();
            IpaymentGateway gt2=new Credit();
            gt2.PaymentProcess();
        }
    }
}
