using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    public class StockVehicle: StockBase, IStockLandTransportation
    {
        public Vehicle Vehicle { get; set; }

        public int calculateVehicleAgeInYears()
        {
            DateTime date = new DateTime(2008, 1, 1, 6, 32, 0);

            try
            {
                return date.Year - PurchaseDate.Value.Year;
            }
            
            catch
            {
                return 0;
            }
            

        }

    }
}
