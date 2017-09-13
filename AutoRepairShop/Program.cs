using AutoRepairShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop myshop = new Shop("MechFix");
            string nameOfTheShop = myshop.Name;
        }
    }
}
