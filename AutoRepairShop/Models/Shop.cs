using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{

    /// <summary>
    /// This class is a Auto Repair shop and represent only a snigle shop.
    /// </summary>
    public class Shop
    {
        //private inside the class
        //1st part of a class - attributes, fields
        private string name;
        private string address;
        private string zip;
        private string city;
        private string phone;
        private string email;
        private List<Customer> customers;

        //2st part of a class - constructor
        public Shop(string Name)
        {
            name = Name;
            customers = new List<Customer>();
        }

        /// <summary>
        /// Adds a new customer to the list/shop
        /// </summary>
        /// <param name="customer"></param>
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public Customer FindCustomer(int id)
        {
            //loop through the list for/while?
            //return the found customer
            foreach(Customer myCustomer in customers)
            {
                if(myCustomer.Id == id)
                {
                    return myCustomer;
                }
                // we dont write else statment because we want to continue the loop
            }
            //if we get down here we did not find the customer
            return null;
        }

        //in order to protect our data we encapsulate
        // protect our private data and show this to the rest of the world
        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Adress
        {
            get
            {
                return email;
            }
            set
            {
                address = value;
            }
        }

        public string Zip
        {
            get
            {
                return zip;
            }
            set
            {
                zip = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
