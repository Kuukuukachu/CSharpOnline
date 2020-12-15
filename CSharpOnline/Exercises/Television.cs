using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Television
    {
        private string _screenSize;
        private string _isMountable;
        private decimal _price;
        private decimal _ports;

        public string ScreenSize { get; set; }
        public string IsMountable { get; set; }
        public string Price { get; set; }
        public string Ports { get; set; }

        public Television(string screenSize, string isMountable)
            : this(600, 9, "55 inches", "is")
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

        public Television () { }
        public virtual void TurnOn()
        {
            Console.WriteLine("The tv is turned on.");
        }
    } // end class


    // Lesson 13 Excercises - Child Classes

    /* Yes I know that best form would be to use two different .cs files, 
     * but these classes are so small that I felt it simpler to just include 
     * them inside the Television.cs file. 
     */

    class OLED : Television
    {
        string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public OLED()
            : this("Samsung")
        {

        }

        public OLED(string brand)
            : base("70 inches", "is not")
        {
            Brand = brand;
        }

        public void HDTV()
        {
            Console.WriteLine("{0} brand OLED TVs are popular.", _brand);
        }

        public override void TurnOn()
        {
            base.TurnOn();
            Console.WriteLine("OLED TVs show brighter colors and darker blacks.");
        }

    } // end class


    class Projectors : Television
    {
        string _style;

        public string Style
        {
            get { return _style; }
            set { _style = value; }
        }
        public Projectors()
            : this("portable projectors")
        {

        }

        public Projectors(string style)
            : base("80 inches", "is")
        {
            Style = style;
        }

        public void Projecting()
        {
            Console.WriteLine("The {0} can be taken anywhere.", _style);
        }
    } // end class
} // end namespace
