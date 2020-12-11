using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Labs
{
        public class Pup : Labwork.Dog
    {
            string _size;
            string _breath;

            public void Chewing()
            {
                Console.WriteLine("The pup chews shoes.");
            }

            public override void TailWag()
            {
                Console.WriteLine("The puppy's tail wags.");
            }
        }
}
