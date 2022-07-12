using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    internal interface IAirTransportation
    {
        public string fuelCalculation(double fuelFlowInNewtonPerHour, double thrust);
    }
}
