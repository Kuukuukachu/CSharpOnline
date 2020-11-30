using System;
using CSharpOnline.Lessons;
using CSharpOnline.Exercises;

namespace CSharpOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLesson5Examples();
            // Console.WriteLine("Hello World!");
            MyLesson5Exercises();
        }

        static void MyLesson5Examples()
        {
            Lesson5 myFive = new Lesson5();
            myFive.ConvertFloatToInt();
            myFive.LongFromInt();
        }
        static void MyLesson5Exercises() 
        {
            Lesson5Exercises myExercise5 = new Lesson5Exercises();
            myExercise5.PrintInt();
            myExercise5.Byte2Int();
            myExercise5.Short2Long();
            myExercise5.Int2Float();
            myExercise5.Double2Long();
            myExercise5.Float2Int();
            myExercise5.Long2Short();
        }
    }
}
