using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace prak2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCollectionsInOrder()
        {
            List<int> collection1 = new List<int> { 1, 2, 3 };
            List<int> collection2 = new List<int> { 1, 2, 3 };
            prak_2.Class1 class1 = new prak_2.Class1();
            bool result = class1.CompareByOrder(collection1, collection2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCollectionsNotInOrder()
        {
            List<int> collection1 = new List<int> { 1, 2, 3 };
            List<int> collection2 = new List<int> { 3, 2, 1 };
            prak_2.Class1 class1 = new prak_2.Class1();
            bool result = class1.CompareIgnoringOrder(collection1, collection2);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPercentageCalculationWithDelta()
        {
            double expected = 33.33;
            prak_2.Class1 class1 = new prak_2.Class1();
            double actual = class1.CalculatePercentage(1, 3);

            double delta = 0.01; // Устанавливаем дельту для погрешности

            Assert.AreEqual(expected, actual, delta);
        }
    }
}
