﻿using AutoRepairShop.Models;
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
            Shop myshop = new Shop("MechFix", "Cambridge ST 100", "90001", "Los Angeles", "+1600330213", "myemail@gmail.com");
            string nameOfTheShop = myshop.Name;
            Console.WriteLine(myshop.Phone);
        }
    }
}