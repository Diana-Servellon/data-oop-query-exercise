using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Note: T? for nullable scenarios

public enum ClientType { Wholesaler, Dealer}
public enum ClientSize { Small, Medium, Large}

namespace Data_Exercise_OOP.BusinessModel.Clients
{
    public class Client: Person
    {
        public ClientType? ClientType { set; get; }
        public ClientSize? ClientSize { set; get; }
        public DateTime? ClientSince { set; get; }
        public bool? IsClientWrthy { set; get; }
        public bool? IsDealer { set; get; }
        public ClientAddress? ClientAddress { set; get; }

        //
        public bool verifyExtraDiscount()
        {
            if (ClientSize != null && ClientSize == global::ClientSize.Large)
            {
                return true;
            }
            return false;
        }

        

    }
}
