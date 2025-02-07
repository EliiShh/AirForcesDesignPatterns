using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirForcesDesignPatterns.AircraftFactoryMethod
{
    public abstract class AircraftFactory
    {
        public abstract IAircraft CreateAircraft(AircraftType type);
    }
}
