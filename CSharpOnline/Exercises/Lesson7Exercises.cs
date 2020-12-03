using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson7Exercises
    {
        public int QuestionOne(int val = 200)
        {
            int result1 = 10 % val;
            Console.WriteLine(result1);
            return (result1);
        }

        public void QuestionTwo(double val1 = 30, double val2 = 50, int val3 = 30, int val4 = 50)
        {
            double adding = val1 += val2;
            Console.WriteLine(adding);

            double multiplying = val1 *= val2;
            Console.WriteLine(multiplying);

            double modulating = val2 %= val1;
            Console.WriteLine(modulating);

            double xoring = val3 ^= val4;
            Console.WriteLine(xoring);
            // doubles cannot be used with XOR, so I made separate int values for this one.
        }

        public void QuestionThree(int val1 = 10, int val2 = 32, int val3 = 12, int val4 = 3)
        {
            int total1 = val1 + val2 * val3 / val4;
            Console.WriteLine(total1);
            int total2 = (val1 + val2) * val3 / val4;
            Console.WriteLine(total2);
        }
    }
}
