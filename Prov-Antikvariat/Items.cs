using System.Collections.Generic;
using System;

namespace Prov_Antikvariat
{
    public class Items
    {
        public int price;
        private string name; 
        private int rarity;
        private string category;
        private int actualValue;
        private bool cursed;
        private Random generator = new Random();

        public void Book()
        {
            List<string> titles = new List<string>() {"a good book", "a great book"};
            List<string> category = new List<string>() {"Horror", "Fantasy", "Kittens", "More Kittens"};

            actualValue = generator.Next(1,101);
            rarity = generator.Next(1,11);
            //name = generator.Next(1, titles.length);
            int determineCursed = generator.Next(1,3);
            if (determineCursed == 1)
            {
                cursed = true;
            }
            else
            {
                cursed = false;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine(actualValue);
        }

        public int Evaluate()
        {
            int correctPrice;
            actualValue * rarity = correctPrice;
            int priceDifference = generator.Next(50,151);
 
            return 0;
        }

        public string GetCategory()
        {

            return "";
        }

    }
}
