//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    class Car
//    {
//        string CarModel, CarColor;
//        int CarYear;

//        public Car(string carmodel, string carcolor, int caryear)
//        {
//            CarModel = carmodel;
//            CarColor = carcolor;
//            CarYear = caryear;

//            if (CarYear <= 1886)
//            {
//                Console.WriteLine("NotFound... ");

//            }
//            else
//            {
//                Console.WriteLine("Car manufacturing Year is : " + CarYear);
//            }




//        }
//        public void CarDetails()

//        {

//            Console.WriteLine("Car Model is : " + CarModel);
//            Console.WriteLine("Car Color is : " + CarColor);
//            Console.WriteLine("Car Year is : " + CarYear);
//        }
//    }
//    internal class CarParameterizedConstructor
//    {
//        static void Main(string[] args)
//        {
//            Car car1 = new Car("BMW", "Black", 1990);
//            car1.CarDetails();
//            Car car2 = new Car("Benz", "White", 2025);
//            car2.CarDetails();

//        }
//    }
//}
