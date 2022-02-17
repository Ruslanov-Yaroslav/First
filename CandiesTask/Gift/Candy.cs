using System;
using System.Collections.Generic;
using System.Text;

namespace CandyesTask
{
    public enum CandyType { Lollipop, ChocolateCandy };

    public class Candy : Sweet
    {
        public CandyType type;

        public Candy(string candyName, int candyWeight, int candySugar, int candyCalories, CandyType type)
            : base(candyName, candyWeight, candySugar, candyCalories)
        {
            this.type = type;
        }

        public override void SweetType()
        {
            Console.WriteLine(type.ToString());
        }
    }
}
