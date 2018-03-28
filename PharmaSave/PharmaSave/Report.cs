using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSave
{
    class Report
    {
        private Dictionary<Item, int> items;

        Report()
        {
            items = new Dictionary<Item, int>();
        }

        void AddItem(Item item, int amount)
        {
            items.Add(item, amount);
        }

        Dictionary<Item, int> GetItems
        {
            get
            {
                return items;
            }
        }

    }
}
