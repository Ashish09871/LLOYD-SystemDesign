using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public sealed class Singleton
    {
        private static int counter = 0;

        private static object lockObj = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        instance = new Singleton();
                    }
                }
                return instance;
            }
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}