using Data_Exercise_OOP.BusinessModel.Invoices;
using Data_Exercise_OOP.BusinessModel.Clients;

namespace Data_Exercise_OOP_Tests.DiscountTests
{
    [TestClass]
    public class DiscountTests
    {
        [TestMethod]
        public void ExtraDiscount()
        {
            Client c = new Client();
            c.ClientSize = ClientSize.Large;
            Invoice invoice = new Invoice();
            invoice.TotalDiscount = 45;
            invoice.Client = c;

            bool result = invoice.ApplyExtraDiscount(500, 0.2); 

            Assert.IsTrue(result);

        }
    }
}
