using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirForcesDesignPatterns.LoggerSingelton;

namespace AirForcesDesignPatterns.AircraftFactoryMethod
{
    public class FighterJet : IAircraft
    {
        public void Fly()
        {
            Logger.Instance.Log("Fighter Jet is flying.");
        }
    }
}
