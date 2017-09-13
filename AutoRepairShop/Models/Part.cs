using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Part
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        private Repair repair;

        public Part()
        {

        }
    }
}
