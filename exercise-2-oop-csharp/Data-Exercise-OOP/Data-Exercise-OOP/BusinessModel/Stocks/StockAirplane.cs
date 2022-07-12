using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    public class StockAirplane: StockBase
    {
        public int Id { get; set; }
        public Airplane AirplaneInfo { get; set; }

    }
}
