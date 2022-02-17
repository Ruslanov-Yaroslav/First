using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CandyesTask
{
    interface iGift
    {
        IEnumerable<Sweet> Sweets { get; }
        void Add(Sweet sweets);
        int GiftWeight();
        void Sort();
        IEnumerable<Sweet> GetSweetsBySuger(int min , int max);
        void ShowItems();
    }
}
