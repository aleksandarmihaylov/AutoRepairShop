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
            int nextCustomerNumber = 1;
            Shop myshop = new Shop("MechFix");
            // create a customer
            Customer myCustomer = new Customer(nextCustomerNumber, "12345678");
            nextCustomerNumber++;
            //continue to set the properties
            myCustomer.FirstName = "John";
            myCustomer.LastName = "Smith";
            //add the customer to the shop
            myshop.AddCustomer(myCustomer);
            //find the customer again
            Customer myFoundCustomer = myshop.FindCustomer(1);
        }
    }
}
