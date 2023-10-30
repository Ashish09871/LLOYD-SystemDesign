//using InternalPkg;
using oops;
using oops.design.abstractfactory;
using oops.design.facade;
using oops.design.observer;
using System.Xml.Linq;
internal class Program
{
    static void Main(string[] args)
    {
        #region Old code
        //DateProperty myDate = new DateProperty();
        ////myDate.Month = 10;
        //Console.WriteLine("Month is set to: " + myDate.Month);
        //Console.ReadLine();

        //Singleton message1 = Singleton.Instance;
        //message1.PrintMessage("This is message 1");

        //Singleton message2 = Singleton.Instance;
        //message2.PrintMessage("This is message 2");

        //IClassA a = new ClassC();
        //a.ShowMessage();

        //IClassB b = new ClassC();
        //b.ShowMessage();

        //ClassC c = new ClassC();
        //c.ShowMessage();
        //((IClassA)c).ShowMessage();
        //((IClassB)c).ShowMessage();

        //DerivedClass c1 = new DerivedClass(-12, "Vijay");
        #endregion

        #region Old code

        //if (args.Length > 0) {
        //    Console.WriteLine(args[0]);
        //}
        //MySealedClass s1 = new MySealedClass();
        //// s1.DisplayMessage();

        //Circle circle = new Circle(5);
        //IShape circle1 = new Circle(5);
        //circle.DisplayMessage();
        //Console.WriteLine("Abstract class Circle area is: " +  circle.CalculateArea());
        //Console.WriteLine("Interface Circle area is: " + circle1.CalculateArea());
        #endregion

        // Factory pattern
        //IShapeFactory circleFactory = new ShapeFactory();
        //oops.design.abstractfactory.IShape circle = circleFactory.CreateShape("circle");
        //circle.Draw();

        //IShapeFactory rectFactory = new ShapeFactory();
        //oops.design.abstractfactory.IShape rect = rectFactory.CreateShape("rectangle");
        //rect.Draw();

        //IShapeFactory hexFactory = new ShapeFactory();
        //oops.design.abstractfactory.IShape hex = hexFactory.CreateShape("hexagon");
        //hex.Draw();

        //EmailFacade efacade = new EmailFacade();
        //efacade.SendEmail("sender@example.com", "recipient@example.com", "Hello", "This is a test email.");

        WeatherStation weatherStation = new WeatherStation();
        Display display1 = new Display();
        Display display2 = new Display();

        weatherStation.Subscribe(display1);
        weatherStation.Subscribe(display2);

        weatherStation.Temperature = 25.5f;

        weatherStation.Unsubscribe(display1);
        weatherStation.Temperature = 15.8f;

        Console.ReadLine();
    }
}