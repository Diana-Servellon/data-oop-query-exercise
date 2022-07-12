using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Stocks
{
    public class Color
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }

        public Color(int colorId, string colorName)
        {
            ColorId = colorId;
            ColorName = colorName;
        }
    }
}
