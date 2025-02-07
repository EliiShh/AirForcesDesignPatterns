using AirForcesDesignPatterns.LoggerSingelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirForcesDesignPatterns.BaseStationObserver
{
    public class AirForceControl : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }

        public void ChangeAircraftStatus(string status)
        {
            Logger.Instance.Log($"Aircraft status changed to: {status}");
            Notify(status);
        }
    }
}
