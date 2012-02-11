using System;
//-----------------
namespace PythaCalc
{
    class Functions
    {
        
        // This is the function that figures out whether a triangle is right or not based on its side's lengths.
        public static bool findOut(double num1, double num2, double num3)
        {
            // doing some serious power stuff.
            double num1p, num2p, num3p;
            num1p = num1 * num1;
            num2p = num2 * num2;
            num3p = num3 * num3;

            // The highest value is the hypotenuse.
            if ((num1 > num2) && (num1 > num3) && (num1p == (num2p + num3p))) return true;
            else if ((num2 > num1) && (num2 > num3) && (num2p == (num1p + num3p))) return true;
            else if ((num3 > num2) && (num3 > num1) && (num3p == (num1p + num2p))) return true;
            // this line isn't accurate, as there's the possibility of two sides having the same value.
            else return false;
            
        }

        // This method finds the length of the hypotenuse based on the length of the other two sides.
        public static double findHypo(double num1, double num2)
        {
            // Declaring stuff.
            double num1p, num2p;
            num1p = num1 * num1;
            num2p = num2 * num2;
            return Math.Sqrt(num1p + num2p);           
        }

        // This method finds the length of a side if the other two lengths are known.
        public static double findSide(double num1, double num2)
        {
            // More declaring action over here.
            double num1p, num2p;
            // Setting up the squared values. If you were wondering, the "p" is for "power".
            num1p = num1 * num1;
            num2p = num2 * num2;

            // This is self explanatory.
            if (num1p > num2p) return Math.Sqrt(num1p - num2p);
            else if (num1p < num2p) return Math.Sqrt(num2p - num1p);
            // I went with -1 because double aren't nullable and it's impossible to get a negative value out of this method.
            else return -1;
        }

    }
}
