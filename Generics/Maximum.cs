﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maximum
    {
        // Method to find maximum integer number.
        public static  int IntegerNo(int firstValue, int secondValue, int thirdValue)
        {            
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
                return firstValue;
            else if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
                return secondValue;
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
                return thirdValue;
            int Value = return;
            throw new Exception("firstValue ,SecondValue and thirdValue are same");
        }
    }
}
