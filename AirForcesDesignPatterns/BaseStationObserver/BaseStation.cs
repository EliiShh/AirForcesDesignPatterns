using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirForcesDesignPatterns.BaseStationObserver
{
    public class BaseStation : IObserver
    {
        private string name;

        public BaseStation(string name)
        {
            this.name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{name} received update: {message}");
        }
    }
}
