using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public class Lesson9Exercises
    {
        public void QuestionOne()
        {
                string[] iceCreams = {"vanilla","strawberry","chocolate","rocky road","pecan praline"};
                {
                    foreach(string value in iceCreams)
                    {
                    Console.WriteLine(value);
                    }
                
                }
        }

        public void QuestionTwo()
        {
            int[,] chiefsScores = new int[,] {
                { 17, 38 },{ 7, 17},{ 27, 17 },{ 20, 27 },{ 40, 26 },{ 28, 10 },{ 28, 33 },{ 34, 30 },{ 19, 13 },{ 31, 24 },
                { 30, 6 },{ 31, 24 },{ 23, 26 },{ 32, 35 },{ 24, 17 },{ 9, 40 },{ 23, 16 },{ 3, 23 },{ 26, 3 },{ 21, 31 },
                { 31, 51 },{ 24, 35 },{ 20, 31 }
            };

            for (int h = 0; h < chiefsScores.GetLength(0); h++)
            {
                Console.WriteLine("Home: {0} | Away: {1}", chiefsScores[h, 0], chiefsScores[h, 1]);
            }
            Console.WriteLine("--");
        }
    }// end class
}// end namespace
