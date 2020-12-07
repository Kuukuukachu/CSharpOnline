using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson8Exercises
    {
        // Question One
        public void QuestionOne(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("The Numbers are Equal.");
            }
            else
            {
                Console.WriteLine("The Numbers are NOT Equal.");
            }
        }

        // Question Two
        public string QuestionTwo(char grade)
        {
            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Not A Valid Grade");
                    break;
            }
            return "Your grade is " +grade;
        }

        // Questions 3
        public void QuestionThree()
        {
            int max = 31;
            for (int i = 0; i < max; i++)
            {
               if(i % 3 == 0) 
                    {
                Console.WriteLine(i);
            }
            }
        }
    } // end class
} // end namespace
