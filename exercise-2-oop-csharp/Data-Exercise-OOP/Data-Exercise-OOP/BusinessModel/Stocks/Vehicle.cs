using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    public class Vehicle: Transportation, ILandTransportation
    {
        public string ModelName { get; set; }

        public string ModelVersion { get; set; }
        public int? Mileage { get; set; }
        public Color Color { get; set; }

        public Vehicle():base()
        {
            ModelName = "";
            ModelVersion = "";
            Mileage = null;
            Color = new Color(1,"Green");
        }

        public Vehicle(int id, string make, int spareParts, 
            string modelName, string modelVersion, int? mileage, Color color): base(id, make, spareParts)
        {
            ModelName = modelName;
            ModelVersion = modelVersion;
            Mileage = mileage;
            Color = color;
        }

        public double GetCarDepreciation(double purchaseCost, double currentCost)
        {
            return currentCost - purchaseCost;
            
        }

    }
}
