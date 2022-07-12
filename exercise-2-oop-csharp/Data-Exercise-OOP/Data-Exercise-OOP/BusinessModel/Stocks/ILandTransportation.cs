using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    interface ILandTransportation
    {
        
        public double GetCarDepreciation(double purchase, double currentCost); //abstract method
    }
}
