using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CandyesTask
{
    public abstract class Sweet
    {
        public string Name { get; private set; }
        public int Weight { get; private set; }
        public int Sugar { get; private set; }
        public int Calories { get; private set; }

        public Sweet(string sweetName , int sweetWeight, int sweetSugar, int sweetCalories)
        {
            this.Name = sweetName;
            this.Weight = sweetWeight;
            this.Sugar = sweetSugar;
            this.Calories = sweetCalories;
        }
        public abstract void SweetType();
    }
}
