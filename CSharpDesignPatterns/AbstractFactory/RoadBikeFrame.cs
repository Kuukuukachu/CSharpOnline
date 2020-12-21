using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class RoadBikeFrame : IBikeFrames
    {
        public string BikeFrameParts
        {
            get { return "Fram parts for the Road Bikes.";  }
        }
    } // end interface
} // end namespace
