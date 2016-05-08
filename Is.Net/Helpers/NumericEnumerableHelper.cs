using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is.Net.Helpers
{
    public class NumericEnumerableHelper
    {
        public static Lazy<NumericEnumerableHelper> Instance = new Lazy<NumericEnumerableHelper>(() => new NumericEnumerableHelper());

        public bool IsSorted(IEnumerable<decimal> values)
        {
            bool retVal = true;

            for (int i = 0; i < values.Count()-1; i++)
            {
                if (!(values.ElementAt(i + 1) > values.ElementAt(i)))
                {
                    retVal = false;
                }
            }

            return retVal;
        }
    }
}
