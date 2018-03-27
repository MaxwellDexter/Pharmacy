using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    static class Category
    {
        private static Dictionary<int, String> _dict = new Dictionary<int, String>();

        public static String getItemCategory(int id)
        {
            return _dict[id];
        }
    }
}
