using Is.Net.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is.Net.UnitTest
{
    [TestClass]
    public class NumericEnumerableHelperTest
    {
        private NumericEnumerableHelper helper
        {
            get
            {
                return NumericEnumerableHelper.Instance.Value;
            }
        }

        [TestMethod]
        [TestCategory("NumericEnumerableHelper")]
        public void IsSorted()
        {
            Assert.IsTrue(helper.IsSorted(new decimal[] { 1, 2, 3, 5, 10, 15, 100 }));
            Assert.IsFalse(helper.IsSorted(new decimal[] { 1, 2, 3, 5, 20, 15, 100 }));
        }
    }
}
