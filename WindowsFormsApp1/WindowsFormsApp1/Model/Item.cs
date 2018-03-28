using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{ 
    class Item
    {
        private int _itemId;
        private String _itemName;
        private int _totalQuantity;
        private int _prodId;
        private String _category;
        private double _price;

        public Item(int itemId, String itemName, int totalQuantity, int prodId, double price)
        {
            _itemId = itemId;
            _itemName = itemName;
            _totalQuantity = totalQuantity;
            ProdID = prodId;
            _price = price;
        }

        public int ProdID
        {
            set
            {
                _prodId = value;
                _category = Category.getItemCategory(_prodId-1);
            }
        }

        public String ItemCategory
        {
            get
            {
                return _category;
            }
        }

        public String ItemName
        {
            get
            {
                return _itemName;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }
    }
}
