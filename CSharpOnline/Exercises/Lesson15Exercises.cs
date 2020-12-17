using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    class Lesson15Exercises
    {
        public enum MovieGenres
        {
            Action, Comedy, Horror, Thriller, Suspense, Romance
        }

        public void FamousMovies(MovieGenres movie)
        {
            string msg = "A famous ";
            switch (movie)
            {
                case MovieGenres.Action:
                    msg += MovieGenres.Action + " movie is Die Hard.";
                    break;
                case MovieGenres.Comedy:
                    msg += MovieGenres.Comedy + " movie is The Wedding Singer.";
                    break;
                case MovieGenres.Horror:
                    msg += MovieGenres.Horror + " movie is IT.";
                    break;
                case MovieGenres.Thriller:
                    msg += MovieGenres.Thriller + " movie is The Silence of the Lambs.";
                    break;
                case MovieGenres.Suspense:
                    msg += MovieGenres.Suspense + " movie is Get Out.";
                    break;
                default:
                    msg += MovieGenres.Romance + " movie is Titanic.";
                    break;
            }
            Console.WriteLine(msg);
        }
    } // end class
} // end namespace
