using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PythaCalc
{
    class Functions
    {
        
        public static bool findOut(double num1, double num2, double num3)
        {
            double num1p, num2p, num3p;
            num1p = num1 * num1;
            num2p = num2 * num2;
            num3p = num3 * num3;

            if ((num1 > num2) && (num1 > num3) && (num1p == (num2p + num3p))) return true;
            else if ((num2 > num1) && (num2 > num3) && (num2p == (num1p + num3p))) return true;
            else if ((num3 > num2) && (num3 > num1) && (num3p == (num1p + num2p))) return true;
            else return false;
            
        }
    }
}
