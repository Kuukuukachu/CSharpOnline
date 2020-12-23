using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class WheelInventory : IWheelVisitor
    {
        private int _spokeCount;
        private int _bearingsCount;
        
        public WheelInventory()
        {
            _spokeCount = 29;
            _bearingsCount = 1;
        }

        public void Visit(IWheel wheel)
        {
            Console.WriteLine("The wheel has {0} spokes and {1} bearings", _spokeCount, _bearingsCount);
        }

        public void Visit(Spokes spoke)
        {
            _spokeCount++;
        }

        public void Visit(Bearings bearing)
        {
            _bearingsCount++;
        }
    } // end class
} // end namespace
