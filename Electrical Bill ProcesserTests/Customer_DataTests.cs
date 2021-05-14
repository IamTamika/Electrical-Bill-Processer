using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Electrical_Bill_Processer.Tests
{
    [TestClass()]
    public class Customer_DataTests
    {
        [TestMethod()] //if the user inputs that 100kWh's were used, the method should charge them just the admin cost of 12 dollars plus the cost of the usage(.07*100)
        public void CalculateCharge_WithOneHundredKwH_UpdatesBillAmount()

        {
            //Arrange
            decimal kWhUsed = 100;
            decimal expected = 19m;
            Customer_Data account;
            account = new Customer_Data("Tamika", "Taylor", kWhUsed);

            //Act
            account.CalculateCharge();

            //Assert
            decimal actual = account.BillAmount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()] //if the user inputs that 100kWh's were used, the method should charge them just the admin cost of 12 dollars plus the cost of the usage(.07*10)
        public void CalculateCharge_WithOneKwH_UpdatesBillAmount()

        {
            //Arrange
            decimal kWhUsed = 1;
            decimal expected = 12.07m;
            Customer_Data account;
            account = new Customer_Data("Tamika", "Taylor", kWhUsed);

            //Act
            account.CalculateCharge();

            //Assert
            decimal actual = account.BillAmount;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]// if the customer inputs 0 kwUsed this term, the method should charge them just the admin cost of 12 dollars
        public void CalculateCharge_WithZeroKwH_UpdatesBillAmount()

        {
            //Arrange
            decimal kWhUsed = 0;
            decimal expected = 12m;
            Customer_Data account;
            account = new Customer_Data("Tamika", "Taylor", kWhUsed);

            //Act
            account.CalculateCharge();

            //Assert
            decimal actual = account.BillAmount;
            Assert.AreEqual(expected, actual);
        }
    }
}