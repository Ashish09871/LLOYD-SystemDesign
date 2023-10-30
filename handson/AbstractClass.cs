using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class AbstractClass
    {

    }

    sealed class MySealedClass { 
        public void DisplayMessage()
        {
            Console.WriteLine("This is a sealed classs");
        }
    }

    public abstract class Shape
    {
        public abstract double CalculateArea();

        public void DisplayMessage()
        {
            Console.WriteLine("This is a shape");
        }
    }

    public class Circle: Shape, IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        double IShape.CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 3);
        }
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width , double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }

    internal interface IShape
    {
        double CalculateArea();
    }
}
