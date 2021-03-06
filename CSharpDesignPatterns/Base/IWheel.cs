﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns
{
    public interface IWheel : IVisitable
    {
        int Size { get; }
        bool Wide { get; }
    } // end interface
} // end namespace
