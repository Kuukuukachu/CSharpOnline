using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class WheelDiagnostics : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnosing the wheels");
        }

        public void Visit(Spokes spoke)
        {
            Console.WriteLine("Diagnosing the spokes");
        }

        public void Visit(Bearings bearing)
        {
            Console.WriteLine("Diagnosing the bearings");
        }
    } // end class
} // end namespace
