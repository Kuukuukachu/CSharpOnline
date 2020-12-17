using System;
using CSharpOnline.Lessons;
using CSharpOnline.Exercises;
using CSharpOnline.Labwork;
using static CSharpOnline.Labs.Pup;

namespace CSharpOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLesson15Examples();
            // MyLesson14Exercises();
            // MyLesson14Examples();
            // MyLesson13Examples();
            // MyLesson12Examples();
            // MyLabwork();
            // MyLesson11Examples();
            // Television();
            // MyLesson10Examples();
            // MyLesson9Exercises();
            // MyLesson9Examples();
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
            // House myHouse = new House();
        }

        static void MyLesson15Examples()
        {
            Lesson15 my15 = new Lesson15();
            my15.BasicEnumCasting();
            my15.MyFavoriteFlavor(Lesson15.IceCreamFlavors.Strawberry);
            // Constants cannot be altered, but can be used.
            Console.WriteLine(Lesson15.words);
            // Indexer - value calling and changing, despite an array (which cannot be changed normally) being used
            my15[2] = 17;
            for(int i = 0; i < my15.ConeArrayLength; i++)
            {
                Console.WriteLine("The value of {0} = {1}", i, my15[i]);
            }
        }

        static void MyLesson14Exercises()
        {
            Lesson14Exercises my14Qs = new Lesson14Exercises();
            Console.WriteLine(Lesson14Exercises.OhmVoltage(8, 10));
            Console.WriteLine(Lesson14Exercises.OhmResistance(500, 5));
            Console.WriteLine(Lesson14Exercises.OhmCurrent(480, 16));

            WaterBirds myBirds = new Goslings();
            myBirds.Hemisphere();
            myBirds.SpringMigration();
            myBirds.AutumnMigration();

        }

        static void MyLesson14Examples()
        {
            Lesson14Static.CelsiusToFahrenheit("34.5");
            Console.WriteLine(Lesson14Static.FahrenheitToCelsius("64"));

            Lesson14Derived myLesson14 = new Lesson14Derived(8);
            myLesson14.ShowResultFeet();
            myLesson14.ShowResultMiles();

            Lesson14Base myBase = new Lesson14Derived(10);
            myBase.ShowResultFeet();
            
        }
        static void MyLesson13Examples()
        {
            House myHouse = new House();
            Console.WriteLine("The door color is {0}", myHouse.DoorColor);
            Condo myCondo = new Condo();
            myCondo.DoorOpenClose();
            Console.WriteLine("The foundation type is {0}", myCondo.Foundation);
        }
        
        static void MyLesson12Examples()
        {
            Lesson12 myTwelve = new Lesson12();
            myTwelve.BasicPublicMethod();
            Lesson12Child myChild = new Lesson12Child();
            myChild.BasicChildMethod();
            myTwelve.BasicProtectedInternalMethod();
        }
        static void MyLabwork()
        {
            Dog myLabwork = new Dog();
            myLabwork.NoseSniff();
            myLabwork.TailWag();
            Labs.Pup myLabwork2 = new Labs.Pup();
            myLabwork2.TailWag();
        }
        static void MyLesson11Examples()
        {
            Condo myCondo = new Condo();
            myCondo.Maintenance();
            myCondo.DoorOpenClose();
            House myHouse = new House();
            myHouse.DoorOpenClose();
            myHouse.DoorOpenClose("red");
        }

        static void Television()
        {
            Television tV13 = new Television();
            Television myTV = new Television("60 inches", "is");
            myTV.TurnOn();

            OLED myOLED = new OLED();
            myOLED.HDTV();
            myOLED.TurnOn();

            Projectors myProjector = new Projectors();
            myProjector.Projecting();
        }
        static void MyLesson10Examples()
        {
            Lesson10 myTen = new Lesson10(); // Default constructor
            Lesson10 myOtherTen = new Lesson10(10);
            Lesson10 lesson10 = new Lesson10(21, "apples");

            Lesson10Struct myStruct = new Lesson10Struct(9.99m, "King", "The Stand");

            int myVal1 = 14, myVal2 = 14;

            myTen.MyBasicRef(ref myVal1, myVal2);
            Console.WriteLine("My Val1 = {0} | My Val2 = {1}", myVal1, myVal2);

            string first, last;
            myTen.MyBasicOut("Foghorn Leghorn", out first, out last);
            Console.WriteLine(first);
            Console.WriteLine(last);
        }
        static void MyLesson9Exercises()
        {
            Lesson9Exercises myWork = new Lesson9Exercises();
            myWork.QuestionOne();
            myWork.QuestionTwo();
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
