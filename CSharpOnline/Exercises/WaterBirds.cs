using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public abstract class WaterBirds : IMovement
    {

        public abstract void SpringMigration();

        public abstract void AutumnMigration();

        public abstract void Hemisphere();

    } // end class

    public class Goslings : WaterBirds
    {
        public override void Hemisphere()
        {
            Console.WriteLine("Birds are cool.");
        }

        public override void AutumnMigration()
        {
            Console.WriteLine("Migratory birds fly south in the autumn.");
        }

        public override void SpringMigration()
        {
            Console.WriteLine("Migratory birds fly north in the spring.");
        }
    } // end class

} // end namespace
