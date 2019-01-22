using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class HandItem 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int Strength { get; set; }
        public int Endurance { get; set; }

        public HandItem()
        {
        }
    }
    

}
