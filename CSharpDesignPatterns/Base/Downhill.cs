using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Downhill : AbstractMountainBike
    {
        public Downhill(IWheel wheel, BikeColor color) 
            :base(wheel, color) { }
        public Downhill(IWheel wheel)
            :this(wheel, BikeColor.Green) { }
        public override decimal Price
        {
            get { return 870.00m; }
        }

    } // end class
} // end space
