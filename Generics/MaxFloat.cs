using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MaxFloat
    {
        // Method to find maximum float number.
        public static float FloatNo(float f1, float f2, float f3)
        {
            if (f1.CompareTo(f2) > 0 && f1.CompareTo(f2) > 0)
                return f1;
            else if (f2.CompareTo(f1) > 0 && f2.CompareTo(f3) > 0)
                return f2;
            else if (f3.CompareTo(f2) > 0 && f3.CompareTo(f2) > 0)
                return f3;
            throw new Exception("firstValue ,SecondValue and thirdValue are same");
        }
    }
}
