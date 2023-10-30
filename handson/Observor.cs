using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops.design.observer
{
    using System;
    using System.Collections.Generic;

    // Subject (Publisher)
    class WeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;

        public float Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                NotifyObservers();
            }
        }

        public void Subscribe(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(Temperature);
            }
        }
    }

    // Observer (Subscriber)
    interface IObserver
    {
        void Update(float temperature);
    }

    class Display : IObserver
    {
        public void Update(float temperature)
        {
            Console.WriteLine("Temperature is now " + temperature + " degrees Celsius.");
        }
    }
}
