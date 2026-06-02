//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    abstract class EletricityBill
//    {
//        public void Display()
//        {
//            Console.WriteLine("Electricity Bill Generated");
//        }
//        public abstract void EleBill(double units);
//    }
//    class ResidentialCust : EletricityBill
//    {
//        public override void EleBill(double units)
//        {
//            double bill = units * 5;
//            Console.WriteLine("Residential Customer Bill is : " + bill);
//        }
//    }
//    class IndustrialCust : EletricityBill
//    {
//        public override void EleBill(double units)
//        {
//            double bill = units * 15;
//            Console.WriteLine("Residential Customer Bill is : " + bill);

//        }
//    }
//    class CommertialCust : EletricityBill
//    {
//        public override void EleBill(double units)
//        {
//            double bill = units * 10;
//            Console.WriteLine("Commertial Customer Bill is : " + bill);

//        }
//    }
//    class AggricuturalCust : EletricityBill
//    {
//        public override void EleBill(double units)
//        {
//            double bill = units * 0;
//            Console.WriteLine("Aggricultural Customer Bill is : " + bill);

//        }
//    }
//    internal class Abstract_ElectricityBill
//    {
       
//        static void Main(string[] args)
//        {
//            EletricityBill obj= new ResidentialCust();
//            obj.Display();
//            Console.WriteLine("Enter number of units consumed by the Customer  ");
//            double unit = Convert.ToDouble(Console.ReadLine());

//            obj.EleBill(unit);
//            obj = new IndustrialCust();
//            obj.EleBill(unit);

//            obj=new CommertialCust();
//            obj.EleBill(unit);
            
//            obj=new AggricuturalCust();
//            obj.EleBill(unit);

//        }
//    }
//}
