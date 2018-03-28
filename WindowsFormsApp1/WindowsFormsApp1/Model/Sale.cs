using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Sale
    {
        private int _itemId;
        private int _quatitySold;

        public Sale(int itemId, int quantitySold)
        {
            this._itemId = itemId;
            this._quatitySold = quantitySold;
        }

        public int QuantitySold
        {
            get
            {
                return _quatitySold;
            }
        }
    }
}
