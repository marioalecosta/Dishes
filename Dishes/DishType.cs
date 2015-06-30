using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishes
{
    public class DishType
    {
        public enum EnumDishes
        {
            [Description("entree")]
            entree = 1,
            [Description("side")]
            side = 2,
            [Description("drink")]
            drink = 3,
            [Description("dessert")]
            dessert = 4
        }
        
    }
}
