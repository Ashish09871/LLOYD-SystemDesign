using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Student: IDisposable
    {
        public int defaultValue = 10;

        private string name;
        private int age;

        private Student(string sName, int sAge)
        {
            name = sName;
            age = sAge;
        }

        public static void AddNumbers(int a, int b)
        {
            Console.WriteLine("This is static call..." + Convert.ToInt32(a + b));
        }

        ~Student()
        {

        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            // clean up the memory here
        }
    }
}