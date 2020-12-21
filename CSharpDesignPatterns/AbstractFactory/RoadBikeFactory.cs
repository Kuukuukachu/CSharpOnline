using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class RoadBikeFactory : AbstractBikeFactory
    {
        public override IBikeFrames CreateBikeFrame()
        {
            return new RoadBikeFrame();
        }
        public override IBikeSeat CreateBikeSeat()
        {
            return new RoadBikeSeat();
        }
    } // end class
} // end namespace
