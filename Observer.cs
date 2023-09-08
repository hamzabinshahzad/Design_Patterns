using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }

    interface IObserver
    {
        void Update(ISubject subject);
    }



    class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;
        public float Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                _temperature = value;
                Notify();
            }
        }

        public WeatherStation()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o => o.Update(this));
        }
    }



    class NewsAgency : IObserver
    {
        public string Name { get; set; }

        public NewsAgency(string n)
        {
            Name = n;
        }

        public void Update(ISubject subject)
        {
            WeatherStation station = subject as WeatherStation;
            if(station != null)
            {
                Console.WriteLine($"{Name}: Reported a temperature of {station.Temperature} degree celsius.\n");
            }
        }
    }

}
