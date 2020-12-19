using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public class Lesson17Exercises
    {
        public string ShoeType { get; private set; }
        public int ShoeSize { get; private set; }
        public string MyResult { get; private set; }

        public delegate void TryOnAnotherPair(string shoes);
        public delegate string TryFavoriteShoes(string favorite);
        public delegate int del(int beta);

        public event TryFavoriteShoes MyEventShoes;

        public Lesson17Exercises()
        {
            TryOnAnotherPair otherShoes = TryOnShoes;
            TryOnALargerPair("pumps", 9, otherShoes);
        }

        public Lesson17Exercises(string type)
        {
            MyEventShoes += new TryFavoriteShoes(this.MyFavoriteShoes);
            MyResult = MyEventShoes(type);
        }

        public Lesson17Exercises(string type, int size)
        {
            ShoeType = type;
            ShoeSize = size;
        }

        public string MyFavoriteShoes(string msg)
        {
            return "My favorite shoes are " + msg + ".";
        }

        public void TryOnALargerPair(string type, int oldSize, TryOnAnotherPair another)
        {
            another("I tried on a pair of " + type + " in size " + (--oldSize) + ".");
        }
        public void TryOnShoes(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
