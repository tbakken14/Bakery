using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Models {
    [TestClass]
    public class ModelTests {
        [TestMethod]
        [DataRow (1, 5)]
        [DataRow (2, 10)]
        [DataRow (3, 10)]
        [DataRow (4, 15)]
        [DataRow (5, 20)]
        [DataRow (6, 20)]
        public void bread_cost_tests(int quantity, int result) {
            Bread bread = new Bread(quantity);
            Assert.AreEqual(bread.getCost(), result);
        }

        [TestMethod]
        [DataRow (1, 2)]
        [DataRow (2, 4)]
        [DataRow (3, 4)]
        [DataRow (4, 6)]
        [DataRow (5, 8)]
        [DataRow (6, 8)]
        public void pastry_cost_tests(int quantity, int result) {
            Pastry pastry = new Pastry(quantity);
            Assert.AreEqual(pastry.getCost(), result);
        }
    }
}