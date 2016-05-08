using Is.Net.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Is.Net.UnitTest
{
    [TestClass]
    public class NumericHelperTest
    {
        private NumericHelper helper
        {
            get
            {
                return NumericHelper.Instance.Value;
            }
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsIntegerWhenDecimal()
        {
            Assert.IsTrue(helper.IsInteger(5.0M));
            Assert.IsFalse(helper.IsInteger(5.1M));
            Assert.IsTrue(helper.IsInteger(-3));
            Assert.IsTrue(helper.IsInteger(0));
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsIntegerWhenString()
        {
            Assert.IsTrue(helper.IsInteger("1"));
            Assert.IsFalse(helper.IsInteger("5.1M"));
            Assert.IsTrue(helper.IsInteger("-3"));
            Assert.IsTrue(helper.IsInteger("0"));
            Assert.IsFalse(helper.IsInteger("a"));
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsEven()
        {
            Assert.IsTrue(helper.IsEven(2));
            Assert.IsFalse(helper.IsEven(3));
            Assert.IsFalse(helper.IsEven(-3));
            Assert.IsTrue(helper.IsEven(0));
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsOdd()
        {
            Assert.IsTrue(helper.IsOdd(3));
            Assert.IsTrue(helper.IsOdd(-3));
            Assert.IsFalse(helper.IsOdd(2));
            Assert.IsFalse(helper.IsOdd(0));
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsAbove()
        {
            Assert.IsTrue(helper.IsAbove(1, 0));
            Assert.IsFalse(helper.IsAbove(-1, 0));
            Assert.IsFalse(helper.IsAbove(0, 0));
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsUnder()
        {
            Assert.IsTrue(helper.IsUnder(-1, 0));
            Assert.IsFalse(helper.IsUnder(1, 0));
            Assert.IsFalse(helper.IsUnder(0, 0));
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsBetween()
        {
            Assert.IsTrue(helper.IsBetween(1, 0, 2));
            Assert.IsFalse(helper.IsBetween(1, 2, 3));
            Assert.IsFalse(helper.IsBetween(2, 1, 2));
            Assert.IsFalse(helper.IsBetween(0, 0, 0));
        }

        [TestMethod]
        [TestCategory("NumericHelper")]
        public void IsFinite()
        {
            Assert.IsTrue(helper.IsFinite(42));
            Assert.IsFalse(helper.IsFinite(double.PositiveInfinity));
            Assert.IsFalse(helper.IsFinite(double.NegativeInfinity));
        }
    }
}
