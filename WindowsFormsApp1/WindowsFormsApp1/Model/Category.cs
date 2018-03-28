using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Category
    {
        private static Dictionary<int, String> _dict = new Dictionary<int, String>();

        public Category(List<String> categoriesList)
        {
            //need to fetch from database or change to non-static
            for(int i=0; i < categoriesList.Count; i++)
            {
                _dict.Add(i, categoriesList[i]);
            }
        }

        public static String getItemCategory(int id)
        {
            return _dict[id];
        }
    }
}
