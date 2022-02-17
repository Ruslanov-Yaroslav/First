using System;
using CandyesTask;
using CandyesTask.SweetsCreate;


namespace CandiesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetsCreate[] sweetsCreate = new SweetsCreate[2];
            sweetsCreate[0] = new CandyCreate();
            sweetsCreate[1] = new ChocolateCreate();

            iGift gift = new Gift();
            foreach(SweetsCreate sc in sweetsCreate)
            {
                if(sc is CandyCreate)
                {
                    gift.Add(sc.Create("Petushok", 80, 105, 125, CandyType.Lollipop));
                    gift.Add(sc.Create("ChupaChups", 25, 75, 70, CandyType.Lollipop));
                    gift.Add(sc.Create("Guliver", 100, 110, 170, CandyType.ChocolateCandy));
                }
                if(sc is ChocolateCreate)
                {
                    gift.Add(sc.Create("Alpen Gold", 100, 115, 250, ChocolateType.White));
                    gift.Add(sc.Create("Milenium", 80, 118, 300, ChocolateType.White));
                    gift.Add(sc.Create("Korona", 100, 110, 220, ChocolateType.White));
                }
            }
            gift.Sort();
            gift.ShowItems();

            Console.WriteLine();
            foreach (var items in gift.GetSweetsBySuger(20, 110))
            {
                Console.WriteLine("Name of candy: {0}, Shugar: {1}", items.Name, items.Sugar);
            }

            Console.WriteLine();
            Console.WriteLine("Present weight: {0}", gift.GiftWeight());
            Console.ReadKey();
        }
    }
}
