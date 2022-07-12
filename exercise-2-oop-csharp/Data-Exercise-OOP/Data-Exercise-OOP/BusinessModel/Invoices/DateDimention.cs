using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Invoices
{
    public class DateDimention
    {
        public int DateKey { set; get; }
        public int Year { set; get; }
        public string MonthAbbr { get; set; }   
        public int QuarterNum { set; get; }
        public string QuarterName { set; get; }
        public string QuarterAbbr { set; get; }

    }
}
