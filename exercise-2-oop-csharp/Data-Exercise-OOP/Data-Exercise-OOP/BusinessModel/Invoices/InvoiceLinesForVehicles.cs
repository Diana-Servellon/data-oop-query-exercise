using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Exercise_OOP.BusinessModel.Stocks;

namespace Data_Exercise_OOP.BusinessModel.Invoices
{
    internal class InvoiceLinesForVehicles
    {
        public int InvoiceID { get; set; }
        public int SalesPrice { get; set; }
        public int LineItem { get; set; }
        public Invoice InvoiceUnit { get; set; }
        public StockVehicle Stock { get; set; }

    }
}
