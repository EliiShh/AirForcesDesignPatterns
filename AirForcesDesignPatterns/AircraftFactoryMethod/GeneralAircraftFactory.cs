using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirForcesDesignPatterns.AircraftFactoryMethod
{
    public class GeneralAircraftFactory : AircraftFactory
    {
        public override IAircraft CreateAircraft(AircraftType type)
        {
            switch (type)
            {
                case AircraftType.FighterJet:
                    return new FighterJet();
                case AircraftType.TransportPlane:
                    return new TransportPlane();
                default:
                    throw new ArgumentException("Invalid aircraft type");
            }
        }
    }
}

