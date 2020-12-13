using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline
{
    /* This class is a child class of House
     Lesson 11 Inheritance */
    class Condo : House
    {
        string _balcony;

        // examples of base keyword calling from a parent constructor
        public string Balcony
        {
            get { return _balcony; }
            set { _balcony = value; }
        }
        public Condo()
            : this ("second floor")
        {

        }

        public Condo(string balcony)
            : base(32, "straw")
        {
            Balcony = balcony;
        }

        public void Maintenance()
        {
            Console.WriteLine("Fixing Condo stuff");
        }

        // example of base keyword use
        public override void DoorOpenClose()
        {
            base.DoorOpenClose();
            Console.WriteLine("The door creaks");
        }

    } // end class
} // end namespacce
