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
            int nextEmployeeNumber = 1;
            Shop myshop = new Shop("MechFix");
            // create a customer
            Customer myCustomer = new Customer(nextCustomerNumber, "12345678");
            nextCustomerNumber++;
            //set the properties on customer
            myCustomer.Name = "John Smith";
            //add the customer to the shop
            myshop.AddCustomer(myCustomer);
            //find the customer again
            Customer myFoundCustomer = myshop.FindCustomer(1);
            //create an employe
            Employee myEmployee = new Employee(nextEmployeeNumber, "+45 30 30 30 30");
            nextEmployeeNumber++;
            //add the employe to the shop
            myshop.AddEmployee(myEmployee);
            //find the employe again
            Employee myFoundEmployee = myshop.FindEmployee(1);
            // creating an invoice
            Invoice myFirstInvoice = new Invoice(1, myFoundCustomer);
            //set properties on the invoice
            myFirstInvoice.Description = "This is the first invoice from my first customer";
            //add the invoice to the customer
            myCustomer.AddInvoice(myFirstInvoice);
            Console.WriteLine(myFoundCustomer.Name);

        }
    }
}
