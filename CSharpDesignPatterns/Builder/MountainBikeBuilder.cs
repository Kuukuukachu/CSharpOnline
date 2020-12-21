using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    class MountainBikeBuilder : BikeBuilder
    {
        private AbstractMountainBike _mountainBikeInProgress;
        public override IBicycle Bicycle
        {
            get { return _mountainBikeInProgress; }
        }

        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike handle bars.");
        }

        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike wide tires.");
        }
    } // end class
} // end namespace
