using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Abstract_Classes_and_Methods
{
    internal class Program
    {
        public abstract class Shape
        {
            public abstract double GetArea();

        }

        public class Circle : Shape
        {
            public double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double GetArea()
            {
                double areaCircle = Math.PI * ((radius) *(radius));
                return areaCircle;
            }
        }

        public class Rectangle:Shape
        {
            public double length;
            public double width;

            public Rectangle(double length, double width) 
            {
                this.length = length;
                this.width = width;
            }

            public override double GetArea()
            {
                double areaRctangle = length * width;

                return areaRctangle;
            }
        }


        static void Main(string[] args)
        {
            Circle myCircle = new Circle(5);

            Console.WriteLine($"Area of the circle = {myCircle.GetArea()}");



            Rectangle myRectangle = new Rectangle(  12.6, 5.8);

            Console.WriteLine($"Area of the rectangle = {myRectangle.GetArea()}");
        }
    }
}
