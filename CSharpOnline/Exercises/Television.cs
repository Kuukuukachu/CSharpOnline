using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public class Television
    {
        private string _screenSize;
        private string _isMountable;
        private decimal _price;
        private decimal _ports;

        public Television(string screenSize, string isMountable)
        {
            _screenSize = screenSize;
            _isMountable = isMountable;

            Console.WriteLine("The screen size is {0} and it {1} mountable.", screenSize, isMountable);
        }

        public Television(decimal price, decimal ports, string screenSize, string isMountable)
        {
            _price = price;
            _ports = ports;
            _screenSize = screenSize;
            _isMountable = isMountable;

            Console.WriteLine("The {0} television has {1} ports, {2} mountable, and costs ${3}.", screenSize, ports, isMountable, price);
        }

        public void TurnOn()
        {
            Console.WriteLine("The tv is turned on");
        }
    } // end class
} // end namespace
