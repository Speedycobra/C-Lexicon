namespace PragueParkingTest
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void RegNrTestValid()
        {
            //-- Arrange
            string regNr = "ABC123";
            int storlek = 4;

            //-- Act
            var Vehicle = new vehicle(regNr, size);

            //-- Assert
            Assert.AreEqual(regNr, vehicle.RegNr);
        }
    }
}