using System;
using CSharpOnline.Lessons;
using CSharpOnline.Exercises;

namespace CSharpOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLesson9Examples();
            // MyLesson8Exercises();
            // BottlesOfBeerSong();
            // MyLesson8Examples();
            // MyLesson7Exercises();
            // MyLesson7Examples();
            // MyLesson6Exercises();
            // MyLesson6Examples();
            // MyLesson5Examples();
            // Console.WriteLine("Hello World!");
            // MyLesson5Exercises();
        }

        static void MyLesson9Examples()
        {
            Lesson9 myNine = new Lesson9();
            myNine.BasicArray();
            myNine.MultiArray2D();
            myNine.My3DArray();
            myNine.MyJaggedArray();
        }

        static void MyLesson8Exercises()
        {
            Lesson8Exercises myWork = new Lesson8Exercises();
            myWork.QuestionOne(1, 1);
            Console.WriteLine(myWork.QuestionTwo('G'));
            myWork.QuestionThree();
        }
        static void BottlesOfBeerSong()
        {
            BottlesOfBeer beer = new BottlesOfBeer();
            Console.WriteLine(beer.LetsSing());
        }
        static void MyLesson8Examples()
        {
            Lesson8 myEight = new Lesson8();
            myEight.BasicIfStatement();
            myEight.BasicIfElseStatement(23);
            Console.WriteLine(myEight.BasicIfElseChainExample(22));
            Console.WriteLine(myEight.BasicAndConditionExample());
            Console.WriteLine(myEight.BasicOrCondition(25));
            myEight.BasicTernaryExample(42);
            myEight.BasicSwitchStatement(3);
            myEight.BasicWhileLoop();
            myEight.BasicDoWhileLoop();
            myEight.BasicForLoopExample(4);
            myEight.BasicForEachExample();
            myEight.BasicJumpStatements();
        }
        static void MyLesson7Exercises()
        {
            Lesson7Exercises myWork = new Lesson7Exercises();
            myWork.QuestionOne();
            myWork.QuestionTwo();
            myWork.QuestionThree();
        }
        static void MyLesson7Examples()
        {
            Lesson7 mySeven = new Lesson7(); //This is an OBJECT INSTANCE.
            mySeven.BasicMath();
            mySeven.BasicModulus();
            mySeven.BasicCheckedOperator(46, 85);
            mySeven.BasicCheckedOperator2();
            mySeven.BasicAssignmentExample();
            mySeven.MyLeftShiftOperator();
            mySeven.MyRightShiftOperator();
            mySeven.MyAndAssignmentOperator(10, 2);
            mySeven.MyOrAssignmentOperator();
            mySeven.MyXorAssignmentOperator();
            mySeven.MyIncrementDecrementExamlpes();
            mySeven.MyIncrementDecrementExamlpes();
        }
        static void MyLesson6Exercises()
        {
            Lesson6Exercises myExercise6 = new Lesson6Exercises();
            myExercise6.Answer1Method();
            myExercise6.Answer2Method();
            myExercise6.Answer3Method();
        }
        static void MyLesson6Examples()
        {
            Lesson6 mySix = new Lesson6();
            mySix.MyTrimExample();
            mySix.MyEqualsExample();
            mySix.MyLowerUpperExample();
            mySix.MyStringLength();
            mySix.MyJoinedStrings("apple", "orange");
            string food = mySix.MyStringBuilder("pizza", 2);
            Console.WriteLine(food);
            mySix.MyExampleChar();
            mySix.MyEscapeExample();
            mySix.MyPlaceHolderExample("Galaga", "shooter");
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
