using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorDemo();
            // ObserverDemo();
            // IteratorDemo2();
            // IteratorDemo1();
            // FacadeDemo();
            // DecoratorDemo();
            // AdapterDemo();
            // SingletonDemo();
            // BuilderDemo();
            // AbstractFactoryDemo();
        }

        static void VisitorDemo()
        {
            IWheel wheel = new WideWheel(22);
            wheel.AcceptVisitors(new WheelDiagnostics());
            wheel.AcceptVisitors(new WheelInventory());
        }
        static void ObserverDemo()
        {
            Speedometer mySpeedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(mySpeedometer);
            Gearbox gear = new Gearbox(mySpeedometer);

            mySpeedometer.CurrentSpeed = 10;
            mySpeedometer.CurrentSpeed = 15;
            mySpeedometer.CurrentSpeed = 20;
            mySpeedometer.CurrentSpeed = 27;
            mySpeedometer.CurrentSpeed = 32;
        }
        static void IteratorDemo2()
        {
            Console.WriteLine("===== Road Bikes =====");
            RoadBikeRange rbRange = new RoadBikeRange();
            foreach (IBicycle bicycle in rbRange.Range)
            {
                Console.WriteLine(bicycle);
            }
            Console.WriteLine("+++++ Mountain Bikes +++++");
            MountainBikeRange mbRange = new MountainBikeRange();
            foreach (IBicycle item in mbRange.Range)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintIterator(IEnumerator iter)
        {
            while(iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

        static void IteratorDemo1()
        {
            Console.WriteLine("===== Road Bikes =====");
            RoadBikeRange roadRange = new RoadBikeRange();
            PrintIterator(roadRange.GetEnumerator());

            Console.WriteLine("+++++ Mountain Bike +++++");
            MountainBikeRange mountainRange = new MountainBikeRange();
            PrintIterator(mountainRange.GetEnumerator());
        }
        static void FacadeDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new Downhill(new WideWheel(20), BikeColor.Red));
        }
        static void DecoratorDemo()
        {
            IBicycle tourBike = new Touring(new NarrowWheel(23));
            Console.WriteLine(tourBike);

            tourBike = new GoldFrame(tourBike);
            Console.WriteLine(tourBike);

            tourBike = new CustomGrip(tourBike);
            Console.WriteLine(tourBike);
        }
        static void AdapterDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new NarrowWheel(20));
            wheels.Add(new WideWheel(24));

            UltraWheel ultraWheel = new UltraWheel(22);
            wheels.Add(new UltraWheelAdapter(ultraWheel));

            foreach (IWheel item in wheels)
            {
                Console.WriteLine(item);
            }
        }

        static void SingletonDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            Console.WriteLine("Next Serial: {0}", generator.NextSerial());
            Console.WriteLine("Next Serial: {0}", generator.NextOtherSerial);
            Console.WriteLine("Next Serial: {0}", generator.NextSerial());
            Console.WriteLine("Next Serial: {0}", generator.NextOtherSerial);
        }
        static void BuilderDemo()
        {
            AbstractMountainBike mountainBike = new Downhill(new WideWheel(24), BikeColor.Red);
            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();

            // Create the bike parts
            IBikeFrames bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();
            // Show what we created
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}
