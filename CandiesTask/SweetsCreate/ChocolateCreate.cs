using System;
using System.Collections.Generic;
using System.Text;

namespace CandyesTask.SweetsCreate
{
    class ChocolateCreate : SweetsCreate
    {
        public override Sweet Create(string candyName, int candyWeight, int candySugar, int candyCalories, CandyType type)
        {
            throw new NotImplementedException();
        }

        public override Sweet Create(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateType type)
        {
            return new Chocolate(candyName, candyWeight, candySugar, candyCalories, type);
        }
    }
}
