using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /* This lesson goes over operators */
    class Lesson7
    {
        // This method goes over Arithemetic operators
        public void BasicMath()
        {
            int a = 20, b = 10;

            int total1 = a + b; // Addition
            int total2 = a - b; // Subtraction
            int total3 = a * b; // Multiplication
            int total4 = b / a; // Division

            Console.WriteLine("Addition = {0}, Subtraction = {1}", total1, total2);
            Console.WriteLine("Multiplication = {0}, Division = {1}", total3, total4);
        }

        // This method shows the Modulus operator
        public void BasicModulus()
        {
            int total = 10 % 20;
            Console.WriteLine(total);
        }

        // This method shows the checked operator method
        public void BasicCheckedOperator(int val, int val2)
        {
            int total = checked(val * val2);
            Console.WriteLine(total);
        }

        // This method shows the checked operator inline block
        public void BasicCheckedOperator2()
        {
            int able = 250, beta = 14;
            checked
            {
                int total = able * beta;
                Console.WriteLine(total);
            }
        }

        // This method shows assignment operators
        public void BasicAssignmentExample()
        {
            int able = 10, beta = 34, charlie = 6;

            able += beta;
            Console.WriteLine(able);

            beta *= charlie;
            Console.WriteLine(beta);
        }

        /*
         The left shift operator will take a value & convert it to binary.
         We can group the numbers of 1's and 0's in groups of 4. We will
         then shift the values to the left based on the 2nd value in the
         expression. The higher order bits outside the range of the result
         are discarded. The remaining bits are shifted left, and the lower
         order empty bits are set to 0.
         */
        public void MyLeftShiftOperator()
        {
            // The number 15 in binary is 0000 1111.
            int value = 15;
            value <<= 2;
            // Shifting the value by 2 results in 0011 1100, which is 60.
            Console.WriteLine(value);
        }

        /*
         The right shift operator will take a value & convert it to binary.
         This binary value will shift to the right by the number of spaces
         based on the 2nd value. When the variable type is int or long, the
         lower order bits are discarded, the remaining are shifted right, &
         the higher order empty bit positions are set to 0 if the value is
         positive; positions are set to 1 for a negative value.
         If the type is uInt or uLong, the empty positions are set to 0.
         */
        public void MyRightShiftOperator()
        {
            // The number 30 in binary is 0001 1110.
            int value = 30;
            value >>= 2;
            // Shifting value by 2 results in 0000 0111.
            Console.WriteLine(value);
        }
        /*
         This AND bitwise compares the binary of both numbers & only the
         matched sets carry to the results.
         */
        public void MyAndAssignmentOperator(int val, int val2)
        {
            // The number 10 in binary is 1010.
            // The number 02 in binary is 0010.
            // Only the matched will carry, so the answer would be 2.
            val &= val2;
            Console.WriteLine(val);
        }

        /*
         This OR bitwise compares the binary of both values and only the 1's
         carry over to the answer.
         */
        public void MyOrAssignmentOperator()
        {
            int value = 15; // binary: 0000 1111
            int value2 = 30; //binary: 0001 1110
            value |= value2;
            Console.WriteLine(value); // result is: 0001 1111 or 31.
        }

        /*
         This XOR bitwise compares the binary of both values. The differences
         will be expressed as 1's in result. Similar values will produce 0's.
         */
        public void MyXorAssignmentOperator()
        {
            int value = 15; // 0000 1111
            int value2 = 30; //0001 1110

            value ^= value2; //0001 0001 = 17
            Console.WriteLine(value);
        }

        // This method will show increment and decrement
        public void MyIncrementDecrementExamlpes()
        {
            int alpha = 11, beta = 16;
            alpha++; //post increment. alpha = alpha + 1
            Console.WriteLine(alpha);
            ++alpha; //pre increment. alpha = 1 + alpha
            Console.WriteLine(alpha);

            beta--; //post decrement. beta = beta - 1
            Console.WriteLine(beta);
            --beta; //pre decrement. beta = 1 - beta
            Console.WriteLine(beta);
        }

    } // end class
} // end namespace
