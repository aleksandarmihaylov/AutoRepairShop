using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Repair
    {
        public int id { get; set; }
        public int hours { get; set; }
        public DateTime dateTime { get; set; }
        public string description { get; set; }
        public string hourlyRate { get; set; }
        public Car car;
        private List<Part> parts;
        //add and find parts
        public Repair()
        {

        }
    }
}
