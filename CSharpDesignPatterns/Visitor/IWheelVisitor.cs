using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public interface IWheelVisitor
    {
        void Visit(IWheel wheel);
        void Visit(Spokes spoke);
        void Visit(Bearings bearing);
    } // end interface
} // end namespace
