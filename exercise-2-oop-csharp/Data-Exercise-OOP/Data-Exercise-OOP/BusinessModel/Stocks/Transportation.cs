using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    public class Transportation
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int SpareParts { get; set; }

        public Transportation() {
            Id = 0;
            Make = "";
            SpareParts = 0;
        }

        public Transportation(int id, string make, int spareParts)
        {
            Id = id;
            Make = make;
            SpareParts = spareParts;
        }
    }
}
