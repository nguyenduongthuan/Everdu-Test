using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShopManagement.src.data;

namespace FruitShopManagement.src.utils
{
    internal class IdComparer : IComparer<Fruit>
    {
        public int Compare(Fruit a, Fruit b)
        {
            return a.Id.CompareTo(b.Id);
        }
    }
}
