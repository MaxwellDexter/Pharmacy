using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmaSave
{
    class Item
    {
        public int item_id;
        public string item_name;
        public float item_price;

        Item()
        {
            item_id = 0;
            item_name = "";
            item_price = 0.0f;
        }

        string GetCSValues
        {
            get
            {
                return item_id.ToString() + "," + item_name + "," + item_price.ToString();
            }
        }
    }
}
