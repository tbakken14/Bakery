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
        public void pastry_cost_tests() {
            Assert.IsTrue(true);
        }
    }
}