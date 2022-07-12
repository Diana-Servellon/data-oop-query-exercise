using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    public class Airplane: Transportation, IAirTransportation
    {
        public int AirplaneId { set; get; }
        public string AirplaneModel { set; get; }
        public int PassengerCapacity { set; get; }
        public string MotorModel { set; get; }
        public double MaximumMotorFuelUsage { set; get; }
        public Color Color { get; set; }

        public string fuelCalculation(double fuelFlowInNewtonPerHour, double thrust) //turbojet engine
        {
            return (fuelFlowInNewtonPerHour / thrust) + " N / kW-h";
        }
    }
}
