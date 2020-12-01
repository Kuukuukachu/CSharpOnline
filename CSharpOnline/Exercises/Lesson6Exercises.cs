using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson6Exercises
    {
        // #1
        public void Answer1Method()
        {
            string _ex6String = "But, soft! What light through yonder window breaks?";
            Console.WriteLine(_ex6String.ToLower());

        }

        // #2

        public void Answer2Method()
        {
            char pilcrowSign = '\u00B6';
            Console.WriteLine(pilcrowSign);
        }

        // #3
        public void Answer3Method()
        {
            string _answer3 = "Jack and Jill\nWent up the hill\nTo fetch a pail of water.\nJack fell down and broke his crown\nAnd Jill came tumbling after.";
            Console.WriteLine(_answer3);
        }

    } // end class
} //end namespace
