using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public interface IVisitable
    {
        void AcceptVisitors(IWheelVisitor visitor);
    } // end interface
} // end namespace
