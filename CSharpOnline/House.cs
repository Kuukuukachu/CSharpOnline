﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline
{
    public class House
    {
        // Attributes of the class
        protected int windowSize;
        protected string foundation;
        // private string _roofType;
        // private string _doorColor;

        // Lesson 13 Encapsulation - Get & Set example
        public int WindowSize
        {
            get { return windowSize; }
            private set { windowSize = value; }
        }

        public string Foundation
        {
            get { return foundation; }
            set { foundation = value; }
        }

        public string RoofType { get; set; }
        public string DoorColor { get; set; }

        // default constructor
        public House() 
            :this(25, "concrete")

        {
        }

        // example of 'this' keyword being called from another constructor.
        public House(int windowSize, string foundation)
            : this(windowSize, foundation, "composite", "Red")
        {

        }

        // example of 'this' keyword.
        public House(int windowSize, string foundation, string roofType, string doorColor)
        {
            this.windowSize = windowSize;
            this.foundation = foundation;
            RoofType = roofType; // this is an auto property
            DoorColor = doorColor;
        }

        /*
         This method will print out
         about what the door does.
            */

        public virtual void DoorOpenClose()
        {
            Console.WriteLine("The door opens");
        }

        // Method Overloading Example
        public void DoorOpenClose(string doorColor)
        {
            Console.WriteLine("My door color is {0}.", doorColor);
        }

    }
}
