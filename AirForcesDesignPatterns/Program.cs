using AirForcesDesignPatterns.LoggerSingelton;
using AirForcesDesignPatterns.AircraftFactoryMethod;
using AirForcesDesignPatterns.BaseStationObserver;


//public class Program
//{
//    static void Main(string[] args)
//    {
//        AircraftFactory aircraftFactory = new GeneralAircraftFactory();

//        IAircraft fighterJet = aircraftFactory.CreateAircraft(AircraftType.FighterJet);
//        fighterJet.Fly();

//        IAircraft transportPlane = aircraftFactory.CreateAircraft(AircraftType.TransportPlane);
//        transportPlane.Fly();

//        AirForceControl control = new AirForceControl();
//        BaseStation base1 = new BaseStation("Base 1");
//        BaseStation base2 = new BaseStation("Base 2");

//        control.Attach(base1);
//        control.Attach(base2);

//        control.ChangeAircraftStatus("Blaaaaa");
//    }
//}
AircraftFactory aircraftFactory = new GeneralAircraftFactory();

IAircraft fighterJet = aircraftFactory.CreateAircraft(AircraftType.FighterJet);
fighterJet.Fly();

IAircraft transportPlane = aircraftFactory.CreateAircraft(AircraftType.TransportPlane);
transportPlane.Fly();

AirForceControl control = new AirForceControl();
BaseStation base1 = new BaseStation("Base 1");
BaseStation base2 = new BaseStation("Base 2");

control.Attach(base1);
control.Attach(base2);

control.ChangeAircraftStatus("Blaaaaa");
