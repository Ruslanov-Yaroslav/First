using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CandyesTask
{
    public class Gift : iGift
    {
        private ICollection<Sweet> sweets;

        public Gift()
        {
            sweets = new List<Sweet>();
        }

        public IEnumerable<Sweet> Sweets
        {
            get
            {
                return this.sweets;
            }
        }

        public void Add(Sweet sweet)
        {
            sweets.Add(sweet);
        }

        public IEnumerable<Sweet> GetSweetsBySuger(int min, int max)
        {
            return sweets.Where(x => (x.Sugar >= min) && (x.Sugar <= max)).ToList();
        }

        public int GiftWeight()
        {
            return sweets.Sum(x => x.Weight);
        }

        public void ShowItems()
        {
            Console.WriteLine("Gift: ");
            foreach (var i in Sweets)
            {
                Console.WriteLine("Name of Candy: {0}, Candy Weight: {1}, Shugar: {2}, Calories: {3},"
                    , i.Name, i.Weight, i.Sugar, i.Calories);

            }
        }

        public void Sort()
        {
            var temp = sweets.OrderBy(x => x.Weight).ToList();
            sweets.Clear();
            foreach(var sweet in temp)
            {
                sweets.Add(sweet);
            }
        }
    }
}
