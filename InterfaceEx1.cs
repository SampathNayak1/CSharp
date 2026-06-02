//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    interface Ishape
//    {
//        double Area();
//        double Perimeter()
//        {
//            return 0;
//        }

//    }

//    class Circle : Ishape
//    {
//        public double Radius { get; set; }
//        public Circle(double radius)
//        {
//            Radius = radius;
//        }
//        public double Area()
//        {
//            return Radius * Radius;
//        }
//        public double Perimeter()
//        {
//            return 2 * Radius;
//        }
//    }

//    class Rectangle : Ishape
//    {
//        public double Height { get; set; }
//        public double Width { get; set; }

//        public Rectangle(double width, double height)
//        {
//            Height = height;
//            Width = width;
//        }
//        public double Area()
//        {
//            return Height * Width;
//        }

//    }
//    internal class InterfaceEx1
//    {
//        static void Main(string[] args)
//        {
//            Ishape obj = new Circle(5); 
//            Console.WriteLine("Perimeter of Circle : " + obj.Perimeter());
//            obj = new Rectangle(10, 5);
//            Console.WriteLine("Area of Rectangle : " + obj.Area());
//            Console.WriteLine("Perimeter of Rectangle : " + obj.Perimeter());
//            Console.WriteLine("Sam");

//        }
//    }
//}
