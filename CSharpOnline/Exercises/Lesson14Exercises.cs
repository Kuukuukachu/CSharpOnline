using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public class Lesson14Exercises
    {
        // Question 1:
        public static double OhmVoltage(int current, int resistance)
        {
            double voltage = current * resistance;
            return voltage;
        }

        public static double OhmCurrent(int voltage, int resistance)
        {
            double current = voltage / resistance;
            return current;
        }

        public static double OhmResistance(int voltage, int current)
        {
            double resistance = voltage / current;
            return resistance;
        }
    } // end class
} // end namespace
