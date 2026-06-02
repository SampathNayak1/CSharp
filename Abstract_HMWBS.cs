//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    abstract class HMWBS
//    {
//        public void BillDetails()
//        {
//            Console.WriteLine("HMWBS Bill is Generated");  
//        }
//        public abstract void GetBill(double units);
//    }
//    class ResidentialCustomer : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//            double bill = units * 7;
//            Console.WriteLine("Residential Customer Bill is : " + bill);
//        }
//    }
//    class CommertialCustomer : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//             double bill= units * 10;
//            Console.WriteLine("Customer Customer Bill is : " + bill);

//        }
//    }
//    class IndustrialCust : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//             double bill=units* 15;
//            Console.WriteLine("Industrial Customer Bill is : " + bill);

//        }
//    }
//    class AggricultureCustomer : HMWBS
//    {
//        public override void GetBill(double units)
//        {
//             double bill=units * 0;
//            Console.WriteLine("Aggricultrual Customer Bill is : " + bill);

//        }
//    }
    

//    internal class Abstract_HMWBS
//    { 
//        static void Main(string[] args)
//        {

//            HMWBS obj= new ResidentialCustomer();
//            obj.BillDetails();
//            Console.WriteLine("Enter number of units consuumed ");
//            double unit=Convert.ToDouble(Console.ReadLine());
//            obj.GetBill(unit);

//            obj=new CommertialCustomer();
//            obj.GetBill(unit);

//            obj= new IndustrialCust();
//            obj.GetBill(unit);

//            obj=new AggricultureCustomer();
//            obj.GetBill(unit); 

//        }
//    }
//}
