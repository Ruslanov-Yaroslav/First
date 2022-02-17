using System;
using System.Collections.Generic;
using System.Text;


namespace CandyesTask.SweetsCreate
{
    public abstract class SweetsCreate 
    {
        public abstract Sweet Create(string candyName, int candyWeight, int candySugar, int candyCalories, CandyType type);
        public abstract Sweet Create(string candyName, int candyWeight, int candySugar, int candyCalories, ChocolateType type);
    }
}
