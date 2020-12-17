using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Lessons
{
    /* This class goes over Lesson 15 Content
     * Enums, Constants, Indexers */
    public class Lesson15
    {
        // Constant Examples
        public const float pi = 3.14f;
        public const string words = "Happy Coding";

        // Enum Examples
        public enum IceCreamFlavors : byte
        {
            Vanilla = 10, Chocolate, Strawberry, RockyRoad, ChocolateChip
        }

        public void BasicEnumCasting()
        {
            int value = (int)Lesson15enum.Thu;
            Console.WriteLine(Lesson15enum.Thu + " " + value);
        }

        public void MyFavoriteFlavor(IceCreamFlavors flavors)
        {
            string msg = "My favorite flavor is "; 
            switch(flavors)
            {
                case IceCreamFlavors.Vanilla:
                    msg += IceCreamFlavors.Vanilla;
                    break;

                case IceCreamFlavors.Chocolate:
                    msg += IceCreamFlavors.Chocolate;
                    break;

                case IceCreamFlavors.Strawberry:
                    msg += IceCreamFlavors.Strawberry;
                    break;

                case IceCreamFlavors.ChocolateChip:
                    msg += IceCreamFlavors.ChocolateChip;
                    break;

                default:
                    msg += IceCreamFlavors.RockyRoad;
                    break;
            }
            Console.WriteLine(msg);
        }

        // Indexer Example

        protected int[] coneSizes = new int[] { 5, 10, 15, 20 };

        public int ConeArrayLength
        {
            get { return coneSizes.Length; }
        }

        public int this[int index] // indexer called here!
        {
            get { return coneSizes[index]; }
            set { coneSizes[index] = value; }
        }

    } // end class
} // end namespace
