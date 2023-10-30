using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    internal class ClassA
    {
        public void ShowMessage()
        {
            Console.WriteLine("Message from Class A");
        }
    }

    internal class ClassB
    {
        public void ShowMessage()
        {
            Console.WriteLine("Message from Class B");
        }
    }

    internal interface IClassA
    {
        void ShowMessage();
    }

    internal interface IClassB
    {
        void ShowMessage();
    }

    internal class ClassC : IClassA, IClassB
    {
        public void ShowMessage()
        {
            Console.WriteLine("Message from C");
        }

        void IClassA.ShowMessage()
        {
            Console.WriteLine("Message from Class A");
        }

        void IClassB.ShowMessage()
        {
            Console.WriteLine("Message from Class B");
        }
    }


    // Base calss usage
    class BaseClass
    {
        public int age;

        public BaseClass(int age)
        {
            this.age = age;
        }
    }

    class DerivedClass : BaseClass
    {
        public string name;

        public DerivedClass(int age, string name) : base(age)
        {
            this.name = name;
            Console.WriteLine("Name is: " + name + " and age is: " + age);
        }
    }
}