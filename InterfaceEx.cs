//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    interface Ishape
//    {
//        void Area();
//        double Perimeter();
//    }
//    public class CircleL : Ishape
//    {
//        public double Radius { get; set; }
//        public void Area()
//        {
//            Console.WriteLine("Area of Circle : " + (Math.PI * Radius * Radius));
//        }
//        public double Perimeter()
//        {
//            return 2 * Math.PI * Radius;
//        }
//    }
//    public class Reclagle : Ishape
//    {
//        public double length { get; set; }
//        public double Width { get; set; }
//        public void Area()
//        {
//            Console.WriteLine("Rectangle Area : " + length * Width);
//        }
//        public double Perimeter()
//        {
//            return 2 * length * Width;
//        }
//    }
//    internal class InterfaceEx
//    {
//        static void Main(string[] args)
//        {
//            Ishape circle = new CircleL { Radius = 5 };
//            circle.Area();
//            Console.WriteLine("Perimetr of Circle " + circle.Perimeter());

//            Ishape rectangle = new Reclagle { length = 10, Width = 20 };
//            circle.Area();
//            Console.WriteLine("Perimetr of Rectangle " + rectangle.Perimeter());

//        }
//    }
//}
