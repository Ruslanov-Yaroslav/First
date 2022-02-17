using System;
using System.Collections.Generic;
using System.Text;

namespace CandyesTask.SweetsCreate
{
    class CandyCreate : SweetsCreate
    {
        public override Sweet Create(string candyName, int candyWeight, int candySugar, int candyCalories, CandyType type)
        {
            return new Candy(candyName,candyWeight,candySugar,candyCalories,type);
        }

        public override Sweet Create(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateType type)
        {
            throw new NotImplementedException();
        }
    }
}
