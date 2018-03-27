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

        public Item(int itemId, String itemName, int totalQuantity, int prodId)
        {
            this._itemId = itemId;
            this._itemName = ItemName;
            this._totalQuantity = totalQuantity;
            this._prodId = prodId;
        }

        public int ProdID
        {
            set
            {
                _prodId = value;
                _category = Category.getItemCategory(_prodId);
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



    }
}
