using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    interface ICar
    {
        void Start();
    }

    class TwoSeaterCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("Two Seater Car ignition...");
        }
    }

    class FourSeaterCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("Four Seater Car ignition...");
        }
    }

    // Now making factory that will be responsible for returning a new car as per demand.
    class CarFactory
    {
        public ICar GetCar(string type)
        {
            switch(type)
            {
                case "TwoSeater":
                    return new TwoSeaterCar();
                case "FourSeater":
                    return new FourSeaterCar();
            }
            return null;
        }
    }
}
