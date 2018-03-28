using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    [TestFixture]
    class ModelTest
    {
        [TestCase]
        public void CheckCategoryReturnString()
        {
            List<String> list = new List<String>();
            list.Add("Medicine");
            list.Add("Accessories");
            Category cat = new Category(list);
            Assert.AreEqual("Medicine", Category.getItemCategory(0).ToString());
        }

        [TestCase]
        public void CheckCreateItem()
        {
            List<String> list = new List<String>();
            list.Add("Medicine");
            list.Add("Accessories");
            Category cat = new Category(list);

            Item item = new Item(1, "Panadol", 20, 1, 2.00);

            Assert.AreEqual("Panadol", item.ItemName.ToString());
            Assert.AreEqual("Medicine", item.ItemCategory.ToString());
            Assert.AreEqual(2.00, item.Price);
        }

        [TestCase]
        public void CheckCreateSale()
        {
            Sale sale = new Sale(1, 8);
            Assert.AreEqual(8, sale.QuantitySold);
        }
    }
}
