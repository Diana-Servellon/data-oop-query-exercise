using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Note: T? for nullable scenarios

namespace Data_Exercise_OOP.BusinessModel.Clients
{
    class Client: Person
    {
        public string? ClientType { set; get; }
        public string? ClientSize { set; get; }
        public DateTime? ClientSince { set; get; }
        public bool? IsClientWrthy { set; get; }
        public bool? IsDealer { set; get; }
        public ClientAddress? ClientAddress { set; get; }

    }
}
