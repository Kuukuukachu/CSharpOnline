using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public class Lesson18Exercises
    {
        public string birthYear { get; set; }
        public void BirthYearLeapYear()
        {
            Console.WriteLine("In what year were you born?");
            string birthYear = Console.ReadLine();

            try
            {
                int value = Int32.Parse(birthYear);
                if (DateTime.IsLeapYear(value))
                {
                    Console.WriteLine("You were born in a Leap Year!");
                }
                else
                {
                    Console.WriteLine("You were not born in a Leap Year!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("A valid year has not been provided.");
            }
        }
    } // end class
} // end namespace
