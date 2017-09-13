using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepairShop.Models
{
    public class Shop
    {
        //private inside the class
        private string name;
        private string address;
        private string zip;
        private string city;
        private string phone;
        private string email;

        //constructor
        public Shop(string Name, string Adress, string Zip, string City, string Phone, string Email)
        {
            name = Name;
            address = Adress;
            zip = Zip;
            city = City;
            phone = Phone;
            email = Email;
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
