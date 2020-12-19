using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{ 

    /* This class goes over the LEsson 17 content
     * Delegates, Events, & Lambdas */
    public class Lesson17
    {
        private string _prop;
        public string MyProperty
        {
            // Remember: Lambda is represented by =>
            // (parameters) => expression-or-statement-block
            get => _prop;
            set => _prop = value;
        }
        public string HatType { get; private set; }
        public int HatSize { get; private set; }
        public string MyResult { get; private set; }

        // Delegate Examples
        public delegate void TryOnAnotherHat(string hat);
        public delegate string TryFavoriteHat(string favorite);
        public delegate int del(int beta);

        //Event example
        public event TryFavoriteHat MyEventHat;

        public Lesson17()
        {
            TryOnAnotherHat otherHat = TryOnHat;
            TryOnALargerHat("fedora", 7, otherHat);
        }

        public Lesson17(string type)
        {
            MyEventHat += new TryFavoriteHat(this.MyFavoriteHat);
            MyResult = MyEventHat(type);
        }

        public Lesson17(string type, int size)
        {
            HatType = type;
            HatSize = size;
        }

        public string MyFavoriteHat(string msg)
        {
            return "My favorite hat is " + msg;
        }

        public void TryOnALargerHat(string type, int oldSize, TryOnAnotherHat another)
        {
            another("I tried on a " + type + " hat at size " + (++oldSize) + ".");
        }

        // 1st example
        public void TryOnHat(string msg)
        {
            Console.WriteLine(msg);
        } // referencing delegate example is in Program.cs.

        // Lambda method example
        public int MyLambdaExample(int value)
        {
            // (parameters) => expression-or-statement-block
            del myDel = x => x * x;
            return myDel(value);
        }

    } // end class
} // end namespace
