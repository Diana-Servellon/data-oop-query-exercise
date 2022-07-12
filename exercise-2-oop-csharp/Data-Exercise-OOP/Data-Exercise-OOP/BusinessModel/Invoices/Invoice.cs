using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Exercise_OOP.BusinessModel.Clients;

namespace Data_Exercise_OOP.BusinessModel.Invoices
{
    public class Invoice
    {
        public int InvoiceId { set; get; }
        public string? InvoiceNumber { set; get; }
        public DateTime? InvoiceDate { set; get; }
        public int DeliveryCharge { set; get; }
        public int? TotalDiscount { set; get; }
        public Client Client { set; get; }
        public DateDimention DateDimentionKey { set; get; }

        public bool ApplyExtraDiscount(int totalPrice, double percentage)
        {
            if (Client.verifyExtraDiscount())
            {

                TotalDiscount += (int)(totalPrice * percentage);

                return true;
            }

            return false;
        }


    }
}
