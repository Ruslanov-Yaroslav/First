using System;
using System.Collections.Generic;
using System.Text;

namespace CandyesTask
{
    public enum ChocolateType { Black , White, Milck };
    public class Chocolate : Sweet
    {
        public ChocolateType type;
        public Chocolate(string chocoName, int chocoWeight, int chocoSugar, int chocoCalories, ChocolateType chocoType)
            : base(chocoName, chocoWeight, chocoSugar, chocoCalories)
        {
            this.type = chocoType;
        }
        public override void SweetType()
        {
            Console.WriteLine(type.ToString()); ;
        }
    }
}
