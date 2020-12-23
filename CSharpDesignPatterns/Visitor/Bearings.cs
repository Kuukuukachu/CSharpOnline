using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public class Bearings : IVisitable
    {
        public void AcceptVisitors(IWheelVisitor visitor)
        {
            visitor.Visit(this);
        }
    } // end class
} // end namespace
