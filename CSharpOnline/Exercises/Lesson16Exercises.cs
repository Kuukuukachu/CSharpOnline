using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOnline.Exercises
{
    public class Lesson16Exercises
    {
        public void Question1Televisions()
        {
            List<Television> myTVs = new List<Television>();
            myTVs.Add(new Television("55 inch", "Is"));
            myTVs.Add(new Television(599, 4, "60 inches", "Is"));

            foreach (Television item in myTVs)
            {
                Console.WriteLine(item);
            }
        }

        public void Question2Houses()
        {
            Dictionary<int, string> myHouses = new Dictionary<int, string>();
            myHouses.Add(10, "brick houses");
            myHouses.Add(11, "adobe houses");
            myHouses.Add(12, "log houses");

            string build = "";
            if (myHouses.TryGetValue(11, out build))
            {
                Console.WriteLine("Key 11 is {0}", build);
            }

            foreach (KeyValuePair<int,string> item in myHouses)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
        }

    }
}
