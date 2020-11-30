using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson5Exercises
    {
        // Values for #1
        int _decVal = 29;
        int _hexVal = 0x1D;
        int _biVal = 0b11101;

        // Values for #2
        byte _byteVal2 = 4;
        short _shortVal2 = 6;
        int _intVal2 = 2500;

        //Values for #3
        double _doubVal3 = 1_348.4;
        long _longVal3 = 1_834_432L;
        float _floatVal3 = -123.6589F;

        //#1: Print Output of the Number 29
        public void PrintInt()
        {
            int decprint = (int)_decVal;
            Console.WriteLine(decprint);

            int hexprint = (int)_hexVal;
            Console.WriteLine(hexprint);

            int biprint = (int)_biVal;
            Console.WriteLine(biprint);

        }

        //#2: Implicit Conversion Methods


        // byte to int
        public void Byte2Int()
        {
            int intValue = _byteVal2;
            Console.WriteLine(intValue);
        }

        //short to long
        public void Short2Long()
        {
            long longValue = _shortVal2;
            Console.WriteLine(longValue);
        }

        // int to float
        public void Int2Float()
        {
            float floatValue = _intVal2;
            Console.WriteLine(floatValue);
        }

        //#3: Explicit Conversion Methods
        // double to long
        public void Double2Long()
        {
            long converted = (long)_doubVal3;
            Console.WriteLine(converted);
        }

        //float to int
        public void Float2Int()
        {
            int converted = (int)_floatVal3;
            Console.WriteLine(converted);
        }

        //long to short
        public void Long2Short()
        {
            short converted = (short)_longVal3;
            Console.WriteLine(converted);
        }

    }
}
