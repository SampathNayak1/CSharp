//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharp
//{
//    abstract class Shape
//    {
//        public double Area { get; set; }
//        public abstract void CalculateArea();
//    }
//    class Circle : Shape
//    {
//        public int Side;
//        public Circle(int Side)
//        {
//            this.Side = Side;
//        }
//        public override void CalculateArea()
//        {
//            Area = Side * Side;
//            Console.WriteLine("Area of Circle is : " + Area);
//        }
//    }
//    class Rectangle : Shape
//    {
//        private double Length;
//        private double Width;
//        public Rectangle(double Length, double Width)
//        {
//            this.Width = Width;
//            this.Length = Length;
//        }
//        public override void CalculateArea()
//        {
//            Area = Length * Width;
//            Console.WriteLine("Area of Rectangle is : " + Area);
//        }
//    }
//    internal class AbstractShape
//    {
//        static void Main(string[] args)
//        {
//            Shape shape = new Circle(10);
//            shape.CalculateArea();
//            Shape shape2 = new Rectangle(10, 20);
//            shape2.CalculateArea();
//        }
//    }
//}
