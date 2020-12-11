using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Labs
{
    class Dog
    {
        string _furColor;
        string _wetNose;
        string _tailLength;

        public void TailWag()
        {
            _furColor = "black";
            _tailLength = "long";
            Console.WriteLine("The {0} dog's {1} tail wags.", _furColor, _tailLength);
        }

        public void NoseSniff()
        {
            _wetNose = "very wet";
            Console.WriteLine("The dog's {0} nose sniffs everything.", _wetNose);
        }

    }
}
