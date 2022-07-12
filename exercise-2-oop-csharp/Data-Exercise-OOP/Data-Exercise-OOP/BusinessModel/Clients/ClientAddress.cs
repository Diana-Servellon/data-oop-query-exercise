using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Exercise_OOP.BusinessModel.Clients
{
    public class ClientAddress
    {
        public int ClientAddressId { get; set; }
        public string? ClientAddressOne { get; set; }
        public string? ClientAddressTwo { get; set; }
        public string Town { get; set; } //not null
        public string? PostCode { get; set; }
        public string? Region { get; set; }
        public Country Country { get; set; }
    }
}
