using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    public class StockBase
    {
        public int StockId { get; set; }
        public int CostPrice { get; set; }
        public int LaborCost { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public DateTime? RegistrationDate { get; set; }
        

    }
}
