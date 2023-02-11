using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maximum
    {
        // Method to find having maximum string length.
        public static  string String(string Line1, string Line2, string Line3)
        {            
            if (Line1.CompareTo(Line2) > 0 && Line1.CompareTo(Line3) > 0)
                return Line1;
            else if (Line1.CompareTo(Line2) > 0 && Line1.CompareTo(Line3) > 0)
                return Line2;
            else if (Line3.CompareTo(Line1) > 0 && Line3.CompareTo(Line2) > 0)
                return Line3;
            throw new Exception("Line1, Line2 and Line3 are same");
        }
    }
}
