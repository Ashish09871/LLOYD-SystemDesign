using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.design.abstractfactory
{
    using System;

    // The Product interface (Shape)
    interface IShape
    {
        void Draw();
    }

    // Concrete Product 1 (Circle)
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    // Concrete Product 2 (Rectangle)
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

    class Hexagon : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a hexagon");
        }
    }

    // The Factory interface
    interface IShapeFactory
    {
        IShape CreateShape(string shapeName);
    }

    // Concrete Factory 1 (Circle Factory)
    class ShapeFactory : IShapeFactory
    {
        public IShape CreateShape(string shapeName)
        {
            switch (shapeName)
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
                case "hexagon":
                    return new Hexagon();
                default:
                    return new Circle();
            }
        }
    }

    //// Concrete Factory 2 (Rectangle Factory)
    //class RectangleFactory : IShapeFactory
    //{
    //    public IShape CreateShape()
    //    {
    //        return new Rectangle();
    //    }
    //}
}