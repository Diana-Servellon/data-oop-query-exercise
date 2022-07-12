using Data_Exercise_OOP.BusinessModel.Stocks;

namespace Data_Exercise_OOP_Tests.VehicleTests
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void Depreciation()
        {
            Color color = new Color(1, "Green");
            Vehicle v = new Data_Exercise_OOP.BusinessModel.Stocks.Vehicle();
            StockVehicle sv = new StockVehicle();
            sv.CostPrice = 40000;

            double result = v.GetCarDepreciation(sv.CostPrice, 60000); //expected 20000

            Assert.AreEqual(result, 20000);

        }
    }
}
